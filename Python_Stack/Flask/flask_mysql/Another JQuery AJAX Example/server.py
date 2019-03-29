from flask import Flask, render_template, redirect, request, session, flash
from mysqlconnection import connectToMySQL
from flask_bcrypt import Bcrypt
import re
app = Flask(__name__)
app.secret_key = "My Secret Key"
bcrypt = Bcrypt(app)

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

@app.route("/")
def index():
    return render_template('wall.html')

@app.route("/success", methods=["POST"])
def register():
    mysql = connectToMySQL("ajaxWall")
    is_valid = True
    if not EMAIL_REGEX.match(request.form["email"]):
        flash("Invalid Email Address")
        is_valid = False
    if len(request.form["username"]) < 3:
        is_valid = False
        flash("Invalid Username")
    if len(request.form["pass"]) < 8:
        is_valid = False
        flash("Password must be at least 8 characters!")
    if request.form["pass"] != request.form["cpass"]:
        is_valid = False
        flash("Passwords don't match")
    if is_valid:
        query = "INSERT INTO users (username, email, password) VALUES (%(username)s, %(email)s, %(pass)s);"
        data = {
            "username": request.form["username"],
            "email": request.form["email"],
            "pass": request.form["pass"]
        }
        result = mysql.query_db(query, data)
        return redirect("/games")
    return redirect("/")

@app.route("/username", methods=['POST'])
def username():
    found = False
    mysql = connectToMySQL('ajaxWall')        # connect to the database
    query = "SELECT username FROM users WHERE users.username = %(user)s;"
    data = { 'user': request.form['username'] }
    result = mysql.query_db(query, data)
    if result:
        found = True
    return render_template('partials/username.html', found=found)  # render a partial and return it
    # Notice that we are rendering on a post! Why is it okay to render on a post in this scenario?
    # Consider what would happen if the user clicks refresh. Would the form be resubmitted?

@app.route("/games")
def games():
    return render_template("games.html")

if __name__ == "__main__":
    app.run(debug=True)