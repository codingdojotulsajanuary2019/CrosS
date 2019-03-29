from flask import Flask, render_template
app = Flask(__name__)

@app.route('/')
def normal():
    return "Hi User!"
@app.route('/play/<x>')
def bluebox(x):
    return render_template('index.html', num=int(x))
@app.route('/play/<x>/<color>')
def bluebox1(x, color):
    return render_template('index.html', num=int(x), hue=color)
if __name__=="__main__":
    app.run(debug=True)