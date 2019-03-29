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

@app.route("/logout")
def logout():
    session.clear()
    return redirect("/")

@app.route("/success", methods=["POST"])
def success():
    mysql = connectToMySQL("favbooks_db")

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

        return redirect("/books")
    return redirect("/")


@app.route("/books")
def books():
    thesess = session['user_id']
    mysql = connectToMySQL("favbooks_db")
    query = "SELECT first_name FROM users WHERE user_id = %(id)s"
    data = {
        "id": thesess
    }
    firstname = mysql.query_db(query, data)
    print(firstname)

    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM books"
    books = mysql.query_db(query)

    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM users"
    userstable = mysql.query_db(query)
    print(userstable)

    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM favorites"
    favstable = mysql.query_db(query)
    print(favstable)


    return render_template("books.html", name = firstname[0]['first_name'], result=books, users=userstable, favorites=favstable, session2=thesess)

@app.route("/login", methods=["POST"])
def login():
    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM users WHERE email = %(em)s;"
    data = {
        "em": request.form["email"]
    }
    result = mysql.query_db(query, data)
    if result:
        if bcrypt.check_password_hash(result[0]["password"], request.form["pass"]):
            session["user_id"] = result[0]["user_id"]
            return redirect('/books')
    flash("You Could not be logged in")
    return redirect("/")

@app.route("/books/<id>/<uid>")
def bookid(id, uid):
    idofbook = int(id)
    w = int(uid)
    x = session["user_id"]
    print(x)
    print("*"*90)
    mysql = connectToMySQL("favbooks_db")
    query = "SELECT first_name FROM users WHERE user_id = %(id)s"
    data = {
        "id": session["user_id"]
    }
    firstname = mysql.query_db(query, data)
    print(firstname)
    
    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM books WHERE book_id = %(idofbook)s"
    data = {
        "idofbook": idofbook
    }
    result = mysql.query_db(query, data)

    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM favorites"
    coffee = mysql.query_db(query)

    mysql = connectToMySQL("favbooks_db")
    query = "SELECT * FROM users"
    bigolusers = mysql.query_db(query)

    return render_template("viewbook.html", name = firstname[0]['first_name'], nameofbook=result, userid=x, bookid=idofbook, theuserid=w, cupofjoe=coffee, allusers=bigolusers)

@app.route("/addnewbook", methods=["POST"])
def addbook():

    is_valid = True
    if len(request.form["title"]) < 1:
        is_valid = False
        flash("Must Enter a Title")
    if len(request.form["desc"]) < 5:
        is_valid = False
        flash("Description must be at least 5 characters")
    if is_valid:
        mysql = connectToMySQL("favbooks_db")
        query = "INSERT INTO books (name, description, users_user_id) VALUES (%(title)s, %(desc)s, %(made)s);"
        data = {
            "title": request.form["title"],
            "desc": request.form["desc"],
            "made": session["user_id"]
        }
        result = mysql.query_db(query, data)
        flash("Book Successfully added")
        return redirect("/books")

    return redirect("/books")

@app.route("/submitnew/<id>", methods=["POST"])
def submitnew(id):
    idofoldbook = int(id)
    mysql = connectToMySQL('favbooks_db')
    query = "UPDATE books SET name = %(newtitle)s, description = %(newdesc)s WHERE book_id = %(bookoldid)s;"
    data = {
        "newtitle": request.form["newtitle"],
        "newdesc": request.form["newdesc"],
        "bookoldid": idofoldbook
    }
    result = mysql.query_db(query, data)
    return redirect('/books')

@app.route("/delete/<id>")
def delete(id):
    idofdeletedbook = int(id)
    mysql = connectToMySQL("favbooks_db")
    query = "DELETE FROM favorites WHERE books_book_id = %(idofbook)s;"
    data = {
        "idofbook": idofdeletedbook
    }
    deletefavs = mysql.query_db(query, data)

    mysql = connectToMySQL("favbooks_db")
    query = "DELETE FROM books WHERE book_id = %(idofbook)s;"
    data = {
        "idofbook": idofdeletedbook
    }
    result = mysql.query_db(query, data)
    return redirect('/books')

@app.route('/addfav/<id>')
def addfav(id):
    idoffavbook = id
    mysql = connectToMySQL("favbooks_db")
    query = "INSERT INTO favorites (books_book_id, users_user_id) VALUES (%(bookadded)s, %(userwhoadded)s);"
    data = {
        "bookadded": idoffavbook,
        "userwhoadded": session['user_id']
    }
    result = mysql.query_db(query, data)
    return redirect('/books')

if __name__ == "__main__":
    app.run(debug=True)