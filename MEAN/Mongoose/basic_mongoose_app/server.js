var express = require('express');
var app = express();
var bodyParser = require('body-parser');

app.use(bodyParser.urlencoded({extended: true}));

var path = require('path');
var session = require('express-session');
app.use(session({
    secret: 'MySuperSecretKey',
    resave: false,
    saveUninitialized: true,
    cookie: {maxAge: 60000}
}))

const flash = require('express-flash');
app.use(flash());

app.use(express.static(path.join(__dirname, '/static')));

app.set('views', path.join(__dirname, '/views'));

app.set('view engine', 'ejs');
var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/basic_mongoose');

var UserSchema = new mongoose.Schema({
    name: {type: String, required: true, minlength: 3},
    age: {type: String, required: true, minlength: 10}
   })
   mongoose.model('User', UserSchema); // We are setting this Schema in our Models as 'User'
   var User = mongoose.model('User') // We are retrieving this Schema from our Models, named 'User'


// Routes
// Root Request
app.get('/', function(request, response) {
    response.render('index');
})

app.post('/users', function(request, response){
    console.log("POST DATA", request.body);
    var user = new User ({name: request.body.name, age: request.body.age});

    user.save(function(error){
        if(error){
            console.log("Something went wrong!"), error;
            for(var key in error.errors){
                request.flash('registration', error.errors[key].message);
            }
        }
        else{
            console.log('Successfully added a User!');
        }
        response.redirect('/quotes');
    })
})

app.get('/quotes', function(request, response){
    User.find({}, function(err, users) {
        console.log(users);
        if(err){
            console.log('Something went wrong!');
            response.redirect('/');
        }
        else{
            console.log('Everything went smoothly!');
            response.render('quotes', {allusers: users});
        }
    })
})



// Setting our Server to Listen on Port: 8000
app.listen(8000, function() {
    console.log("listening on port 8000");
});