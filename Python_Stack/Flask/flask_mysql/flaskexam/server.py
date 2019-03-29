from flask import Flask, redirect, render_template, session, request, flash
from mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
import re

app = Flask(__name__)
app.secret_key = "My Secret Key"
bcrypt = Bcrypt(app)

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

@app.route("/")
def index():
    return render_template("index.html")


@app.route("/login", methods=["POST"])
def login():
    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT * FROM users WHERE email = %(em)s;"
    data = {
        "em": request.form["email"]
    }
    result = mysql.query_db(query, data)
    if result:
        if bcrypt.check_password_hash(result[0]["password"], request.form["pass"]):
            session["user_id"] = result[0]["user_id"]
            return redirect('/wishes')
    flash("You Could not be logged in")
    return redirect("/")

@app.route("/success", methods=["POST"])
def success():
    mysql = connectToMySQL("flaskexam_db")

    is_valid = True
    if not EMAIL_REGEX.match(request.form["email"]):
        flash("Invalid Email Address")
        is_valid = False
    if len(request.form["first"]) < 2:
        is_valid = False
        flash("Please enter a First Name")
    if len(request.form["last"]) < 2:
        is_valid = False
        flash("Please enter a Last Name")
    if len(request.form["pass"]) < 8:
        is_valid = False
        flash("Password must be at least 8 characters!")
    if request.form["pass"] != request.form["cpass"]:
        is_valid = False
        flash("Passwords don't match")
    if is_valid:
        pw_hash = bcrypt.generate_password_hash(request.form["pass"])
        query = "INSERT INTO users (first_name, last_name, email, password) VALUES (%(fn)s, %(ln)s, %(em)s, %(pass)s);"
        data = {
            "fn": request.form["first"],
            "ln": request.form["last"],
            "em": request.form["email"],
            "pass": pw_hash
            }
        print(data)
        user_id = mysql.query_db(query, data)
        session["user_id"] = user_id
        flash("Friend Successfully Added!")

        return redirect("/wishes")
    return redirect("/")

@app.route("/logout")
def logout():
    session.clear()
    return redirect("/")

@app.route("/wishes")
def wishes():
    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT first_name FROM users WHERE user_id = %(id)s"
    data = {
        "id": session["user_id"]
    }
    firstname = mysql.query_db(query, data)
    print(firstname)

    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT * FROM wishes WHERE users_user_id = %(id)s"
    data = {
        "id": session['user_id']
    }
    y = mysql.query_db(query, data)
    print(y)

    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT * FROM users"
    data = {
        "id": session['user_id']
    }
    x = mysql.query_db(query)
    print(x)

    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT * FROM grantedwishes WHERE users_user_id = %(id)s"
    data = {
        "id": session['user_id']
    }
    z = mysql.query_db(query, data)
    print("*"*90)
    print(z)

    return render_template("secondPage.html", name = firstname[0]['first_name'], wishes = y, users = x, grantedwishes = z)

@app.route("/wishes/new")
def makeawish():
    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT first_name FROM users WHERE user_id = %(id)s"
    data = {
        "id": session["user_id"]
    }
    firstname = mysql.query_db(query, data)
    print(firstname)

    return render_template("makeawish.html", name=firstname[0]['first_name'])

@app.route("/makeawish", methods=["POST"])
def newwish():
    is_valid = True
    if len(request.form["mywish"]) < 3:
        is_valid = False
        flash("Title must be at least 3 characters long!")
    if len(request.form["desc"]) < 3:
        is_valid = False
        flash("Description must be at least 3 characters long!")
    if is_valid:
        mysql = connectToMySQL("flaskexam_db")
        query = "INSERT INTO `flaskexam_db`.`wishes` (`name`, `desc`, `users_user_id`) VALUES (%(wish)s, %(desc)s, %(id)s);"
        data = {
            "wish": request.form["mywish"],
            "desc": request.form["desc"],
            "id": session["user_id"]
        }
        result = mysql.query_db(query, data)
        print('*'*90)
        print(result)
        return redirect("/wishes")
    return redirect('/wishes/new')

@app.route("/delete/<id>")
def delete(id):
    j = id
    mysql = connectToMySQL("flaskexam_db")
    query = "DELETE FROM wishes WHERE wish_id = %(id)s"
    data = {
        "id": j
    }
    result = mysql.query_db(query, data)
    return redirect("/wishes")

@app.route("/edit/<id>")
def edit(id):
    thewishid = id
    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT first_name FROM users WHERE user_id = %(id)s"
    data = {
        "id": session["user_id"]
    }
    firstname = mysql.query_db(query, data)
    print(firstname)

    return render_template("edit.html", name=firstname[0]['first_name'], thewishesid = thewishid)

@app.route("/changewish/<id>", methods=["POST"])
def changewish(id):
    j = id
    is_valid = True
    if len(request.form["mynewwish"]) < 3:
        is_valid = False
        flash("Must Enter a wish at least 3 characters long")
    if len(request.form["newdesc"]) < 3:
        is_valid = False
        flash("Must enter a description at least 3 characters long")
    if is_valid:
        mysql = connectToMySQL("flaskexam_db")
        query = "UPDATE  `flaskexam_db`.`wishes` SET `name` = %(newname)s, `desc` = %(newdesc)s WHERE `wish_id` = %(id)s"
        data = {
            "newname": request.form["mynewwish"],
            "newdesc": request.form["newdesc"],
            "id": j
        }
        result = mysql.query_db(query, data)
        print("*"*90)
        print(result)

        return redirect("/wishes")
    return redirect("/edit/18")

@app.route("/granted/<id>")
def granted(id):
    j = id
    mysql = connectToMySQL("flaskexam_db")
    query = "SELECT * FROM wishes WHERE wish_id = %(id)s"
    data = {
        "id": j
    }
    result = mysql.query_db(query, data)

    mysql = connectToMySQL("flaskexam_db")
    query = "INSERT INTO grantedwishes (grantedwishes.name, grantedwishes.desc, grantedwishes.date_added, grantedwishes.users_user_id) VALUES (%(thename)s, %(thedesc)s, %(thedate)s, %(theid)s);"
    data = {
        "thename": result[0]['name'],
        "thedesc": result[0]['desc'],
        "thedate": result[0]['date_added'],
        "theid": result[0]['users_user_id'],
        "id": j
    }
    done = mysql.query_db(query, data)
    print(done)


    mysql = connectToMySQL("flaskexam_db")
    query = "DELETE FROM wishes WHERE wish_id = %(id)s"
    data = {
        "id": j
    }
    print("*"*90)
    result = mysql.query_db(query, data)



    return redirect("/wishes")

if __name__ == "__main__":
    app.run(debug=True)