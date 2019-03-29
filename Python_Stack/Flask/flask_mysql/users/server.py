from flask import Flask, redirect, render_template, request
from mysqlconnection import connectToMySQL
app = Flask(__name__)

@app.route("/users")
def viewusers():
    mysql = connectToMySQL("users_db")
    users = mysql.query_db("SELECT * FROM users;")
    return render_template("viewusers.html", allusers=users)

@app.route("/users/new")
def adduser():

    return render_template("newuser.html")


@app.route("/addingnew", methods=["POST"])
def addingnew():
    mysql = connectToMySQL("users_db")

    z = request.form["first"] + " " + request.form["last"]
    print(z)
    query = "INSERT INTO users (first_name, last_name, email, full_name) VALUES (%(fn)s, %(ln)s, %(em)s, %(full)s);"
    data = {
    "fn": request.form["first"],
    "ln": request.form["last"],
    "em": request.form["email"],
    "full": z
    }
    print(data)
    user_id = mysql.query_db(query, data)
    return redirect("/users")


@app.route("/users/<id>")
def viewauser(id):
    mysql = connectToMySQL("users_db")
    v = int(id)
    print(v)
    query = "SELECT * FROM users WHERE user_id = %(x)s;"
    data = {
        "x": v
    }
    print(data)
    person_id = mysql.query_db(query, data)
    print(person_id)
    return render_template("oneUser.html", users_data="users_db", y=person_id)

@app.route("/users/<id>/edit")
def index(id):
    mysql = connectToMySQL("users_db")
    v = int(id)
    query = "SELECT user_id FROM users WHERE user_id = %(i)s;"
    data = {
        "i": v
    }
    person_id = mysql.query_db(query, data)
    print(v)
    return render_template("editUsers.html", users_data="users_db", l=person_id, m=v)

@app.route("/editinguser/<id>", methods=["POST"])
def editing(id):
    mysql = connectToMySQL("users_db")
    x = int(id)
    z = request.form["newfirst"] + " " + request.form["newlast"]
    print("hi")
    query = "UPDATE users SET first_name = %(firstname1)s, last_name = %(lastname1)s, email = %(email1)s, full_name = %(fullname)s WHERE user_id = %(w)s;"
    data = {
        "firstname1": request.form["newfirst"],
        "lastname1": request.form["newlast"],
        "email1": request.form["newemail"],
        "fullname": z,
        "w": x
    }
    user_id = mysql.query_db(query, data)
    return redirect("/users")



@app.route("/delete/<id>")
def delete(id):
    mysql = connectToMySQL("users_db")
    j = id
    print("hi")
    query = "DELETE FROM users WHERE user_id = %(id)s"
    data = {
        "id": j
    }
    user_id = mysql.query_db(query, data)
    return redirect("/users")



if __name__ == "__main__":
    app.run(debug=True)