from flask import Flask, render_template, request, redirect
from mysqlconnection import connectToMySQL    # import the function that will return an instance of a connection
app = Flask(__name__)
@app.route("/")
def index():
    mysql = connectToMySQL('sql_pets')	        # call the function, passing in the name of our db
    pets = mysql.query_db('SELECT * FROM pets;')  # call the query_db function, pass in the query as a string
    return render_template("index.html", all_pets=pets)
            
@app.route("/add", methods=["POST"])
def addpet():
    mysql = connectToMySQL("sql_pets")

    query = "INSERT INTO pets (name, type) VALUES (%(n)s, %(t)s);"
    data = {
    "n": request.form["newname"],
    "t": request.form["newtype"]
    }
    pet_id = mysql.query_db(query, data)
    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)