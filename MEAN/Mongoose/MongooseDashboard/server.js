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

app.use(express.static(path.join(__dirname, '/static')));

app.set('views', path.join(__dirname, '/views'));

app.set('view engine', 'ejs');
var mongoose = require('mongoose');
mongoose.connect('mongodb://localhost/MongooseDashboard');

var DuckSchema = new mongoose.Schema({
    color: String,
    age: Number,
    gender: String
   })
   mongoose.model('Duck', DuckSchema); // We are setting this Schema in our Models as 'User'
   var Duck = mongoose.model('Duck'); // We are retrieving this Schema from our Models, named 'User'

app.get('/', function(request, response) {
    Duck.find({}, function(error, ducks){
        console.log(ducks);
        if(error){
            console.log("Something went wrong!");
            response.redirect('/ducks/new');
        }
        else{
            console.log("Everything went smoothly!");
            response.render('index', {allducks: ducks});
        }
    })
});

app.get('/ducks/new', function(request, response){
    response.render('newduck');
})

app.post('/newduck', function(request, response){
    console.log("POST DATA", request.body);
    var duck = new Duck ({color: request.body.color, age: request.body.age, gender: request.body.gender});

    duck.save(function(error){
        if(error){
            console.log("Something went wrong!");
            response.render('newduck');
        }
        else{
            console.log('Successfully added a new duck!');
        }
        response.redirect('/');
    })
})

app.get('/ducks/:id', function(request, response){
    var duckid = request.params.id;
    console.log("****************************************************");
    console.log(duckid)
    Duck.find({}, function(error, ducks){
        console.log(ducks);
        if(error){
            console.log("Something went wrong!");
            response.redirect('/');
        }
        else{
            console.log("Everything went smoothly!");
            response.render('oneduck', {allducks: ducks, theduck: duckid});
        }
    })
})

app.get('/duck/delete/:id', function(request, response){
    Duck.remove({_id: request.params.id}, function(error, ducks){
        console.log(ducks);
        if(error){
            console.log('Duck was not removed, error!');
            response.redirect('/');
        }
        else{
            console.log("Duck successfully removed!");
            response.redirect('/');
        }
    })
});

app.get('/duck/edit/:id', function(request, response){
    var duckid = request.params.id;
    Duck.find({}, function(error, ducks){
        console.log(ducks);
        if(error){
            console.log('Could not find all ducks!');
        }
        else{
            console.log('Smooth as ice!');
            response.render('editduck', {allducks: ducks, theduckid: duckid});
        }
    })
})

app.post('/duck/update/:id', function(request, response){
    Duck.update({_id: request.params.id}, {$set: {color: request.body.newcolor, age: request.body.newage, gender: request.body.newgender}} , function(error, ducks){
        console.log(ducks);
        console.log("IM HERE!");
        if(error){
            console.log('Cannot edit duck, error!');
            response.redirect('/');
        }
        else{
            console.log('Duck updated!');
            response.redirect('/');
        }
    })
})

app.listen(8000, function() {
    console.log("listening on port 8000");
});