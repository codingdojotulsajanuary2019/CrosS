from flask import Flask, request, render_template, redirect, session, flash
from mysqlconnection import connectToMySQL
import re
app = Flask(__name__)
app.secret_key = "My Secret Key"

EMAIL_REGEX = re.compile(r'^[a-zA-Z0-9.+_-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$')

@app.route("/")
def index():

    return render_template("index.html")

@app.route("/emaildisplay")
def emaildisplay():
    mysql = connectToMySQL("emailadds_db")
    emails = mysql.query_db("SELECT * FROM emails")
    print(emails)
    return render_template("emaildisplay.html", allemails=emails)

@app.route("/add", methods=["POST"])
def addemail():
    mysql = connectToMySQL("emailadds_db")
    if not EMAIL_REGEX.match(request.form['email']):
        flash("Invalid email address!")
        return redirect("/")
    if EMAIL_REGEX.match(request.form["email"]):
        query = "INSERT INTO emails (email) VALUES (%(x)s);"
        data = {
            "x": request.form["email"]
        }
        email_id = mysql.query_db(query, data)
        return redirect("/emaildisplay")


if __name__ == "__main__":
    app.run(debug=True)