from flask import Flask, render_template, redirect, session, request
import random

app = Flask(__name__)
app.secret_key="My Secret Key"

@app.route("/")
def index():
    if "gold" not in session:
        session["gold"] = 0
    return render_template("index.html")

@app.route("/process_money", methods=["POST"])
def process():
    x = request.form["which_property"]
    print("*"*90)
    print(x)
    if x == "farm":
        session["gold"] = session["gold"] + random.randint(10,20)
    if x == "cave":
        session["gold"] = session["gold"] + random.randint(5,10)
    if x == "house":
        session["gold"] = session["gold"] + random.randint(2,5)
    if x == "casino":
        session["gold"] = session["gold"] + random.randint(-50,50)
    return redirect("/")

@app.route("/clear")
def clearsession():
    session.clear()
    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)