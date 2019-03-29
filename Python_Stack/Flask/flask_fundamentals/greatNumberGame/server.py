from flask import Flask, redirect, render_template, request, session
import random
app = Flask(__name__)
app.secret_key = "My Secret Key"

x = random.randint(1,101)

@app.route("/")
def index():
    if "y" not in session:
        session['y'] = 0
    return render_template("index.html", number=x, guess=int(session["y"]))

@app.route("/outcome", methods=["POST"])
def outcome():
    print("*"*90)
    session["y"] = request.form["numberbox"]
    print("after")
    return redirect("/")

'''@app.route("/correct")
def correct'''


if __name__ == "__main__":
    app.run(debug=True)