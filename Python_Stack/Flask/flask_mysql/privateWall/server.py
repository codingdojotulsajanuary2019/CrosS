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
    mysql = connectToMySQL("privatewall_db")
    return render_template("index.html")






@app.route("/wall")
def wall():
    mysql = connectToMySQL("privatewall_db")
    query = "SELECT first_name FROM users WHERE user_id = %(id)s"
    data = {
        "id": session["user_id"]
    }
    firstname = mysql.query_db(query, data)
    print(firstname)

    mysql = connectToMySQL("privatewall_db")
    query = "SELECT * FROM messages WHERE recipient_id = %(id)s"
    data = {
        "id": session["user_id"]
    }
    message = mysql.query_db(query, data)
    print(message)

    mysql = connectToMySQL("privatewall_db")
    query = "SELECT * FROM users"
    peoples = mysql.query_db(query)
    print(peoples)

    return render_template("wall.html", name = firstname[0]['first_name'], persons = peoples, messages = message)






@app.route("/delete", methods=["POST"])
def delete():
    mysql = connectToMySQL("privatewall_db")
    query = "DELETE FROM messages WHERE message_id = %(id)s"
    data={
        "id": request.form["themessageid"]
    }
    execute = mysql.query_db(query, data)
    return redirect("/wall")






@app.route("/success", methods=["POST"])
def register():
    mysql = connectToMySQL("privatewall_db")

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

        return redirect("/wall")
    return redirect("/")









@app.route("/login", methods=["POST"])
def login():
    mysql = connectToMySQL("privatewall_db")
    query = "SELECT * FROM users WHERE email = %(em)s;"
    data = {
        "em": request.form["email"]
    }
    result = mysql.query_db(query, data)
    if result:
        if bcrypt.check_password_hash(result[0]["password"], request.form["pass"]):
            session["user_id"] = result[0]["user_id"]
            return redirect('/wall')
    flash("You Could not be logged in")
    return redirect("/")







@app.route("/logout")
def logout():
    session.clear()
    return redirect("/")








@app.route("/sendmessage", methods=["POST"])
def sendingmessage():
    mysql = connectToMySQL("privatewall_db")


    mysql = connectToMySQL("privatewall_db")
    query = "INSERT INTO messages (content, users_user_id, recipient_id) VALUES (%(con)s, %(id)s, %(rid)s);"
    data = {
        "con": request.form["messagesent"],
        "id": session['user_id'],
        "rid": request.form["thepersonsids"]
    }
    print(data)
    message = mysql.query_db(query, data)

    return redirect("/wall")





if __name__ == "__main__":
    app.run(debug=True)