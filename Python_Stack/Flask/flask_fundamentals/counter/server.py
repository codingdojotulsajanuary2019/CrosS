from flask import Flask, session, render_template, redirect, request

app = Flask(__name__)
app.secret_key = "My Secret Key"

@app.route("/")
def index():
    if "count" not in session:
        session["count"] = 1
    else: session["count"] = session["count"] + 1
    return render_template("index.html", number=session["count"])

@app.route("/destroy_session")
def destroy():
    session.clear()
    return redirect("/")

if __name__ == "__main__":
    app.run(debug=True)