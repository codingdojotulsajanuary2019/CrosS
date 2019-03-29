from flask import Flask  # Import Flask to allow us to create our app
app = Flask(__name__)    # Create a new instance of the Flask class called "app"
@app.route('/')          # The "@" decorator associates this route with the function immediately following
def hello_world():
    return 'Hello World!'  # Return the string 'Hello World!' as a response
@app.route('/dojo')
def success():
    return "Dojo!"
@app.route('/hello/<name>')
def hello(name):
    print(name)
    return name+"!"
@app.route('/repeat/<repeat>/<word>') # for a route '/users/____/____', two parameters in the url get passed as username and id
def show_user_profile(word, repeat):
    print(word)
    print(repeat)
    return word * int(repeat)
if __name__=="__main__":   # Ensure this file is being run directly and not from a different module    
    app.run(debug=True)    # Run the app in debug mode.