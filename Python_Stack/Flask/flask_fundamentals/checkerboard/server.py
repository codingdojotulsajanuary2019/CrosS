from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def checkers():
    print("hi")
    return "How's it going?!"
@app.route('/<x>/<y>/<z>/<color>')
def display(x, y, z, color):
    return render_template('index.html', xtimes=int(x), ytimes=int(y), ztimes=int(z), hue=color)
if __name__=="__main__":
    app.run(debug=True)