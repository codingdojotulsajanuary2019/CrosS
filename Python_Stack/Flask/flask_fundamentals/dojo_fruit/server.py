from flask import Flask, render_template, request, redirect
app = Flask(__name__)  

@app.route('/')         
def index():
    return render_template("index.html")

@app.route('/checkout', methods=['POST'])         
def checkout():
    print(request.form)
    first=request.form["first_name"]
    last=request.form["last_name"]
    count1=request.form["strawberry"]
    count2=request.form["raspberry"]
    count3=request.form["apple"]
    fullcount=int(count3)+(int(count2))+(int(count1))
    print("*"*90)
    print("Charging {} {} for {} fruits.".format(first, last, fullcount))
    fruit1=request.form["strawberry"]
    fruit2=request.form["raspberry"]
    fruit3=request.form["apple"]
    return render_template("checkout.html", strawberry=fruit1, raspberry=fruit2, apple=fruit3)

@app.route('/fruits')         
def fruits():
    return render_template("fruits.html")

if __name__=="__main__":   
    app.run(debug=True)