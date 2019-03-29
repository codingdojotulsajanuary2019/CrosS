from flask import Flask, render_template, redirect, request, flash
from mysqlconnection import connectToMySQL

app = Flask(__name__)
app.secret_key = "My Secret Key"

@app.route("/")
def index():
    print("Made it this FAR!")
    return render_template("index.html")

@app.route("/process", methods=['POST'])
def info():
    mysql = connectToMySQL("dojosurvey_db")
    is_valid = True
    if len(request.form["username"]) < 1:
        is_valid = False
        flash("Please enter your name.")
    if is_valid:
        print("got to the process")
        print(request.form)
        username=request.form["username"]
        location=request.form["location"]
        language=request.form["language"]
        comment=request.form["comment"]

        query = "INSERT INTO users (name, language, location, comment) VALUES (%(n)s, %(l)s, %(lc)s, %(c)s);"
        data = {
            "n": request.form["username"],
            "l": request.form["language"],
            "lc": request.form["location"],
            "c": request.form["comment"]
        }
        user_id = mysql.query_db(query, data)
        print(user_id)

        flash("Friend Successfully Added!")
        return redirect("info.html", name=username, dojo=location, lingo=language, words=comment)


    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)