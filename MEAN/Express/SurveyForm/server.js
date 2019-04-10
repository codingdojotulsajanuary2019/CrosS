var express = require('express');
var app = express();
var bodyParser = require('body-parser');

var session = require('express-session');
app.use(session({
    secret: 'SuperSecretKey',
    resave: false,
    saveUninitialized: true,
    cookie: {maxAge: 60000}
}));

app.use(bodyParser.urlencoded({extended: true}));

app.use(express.static(__dirname + "/static"));
app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');

app.get('/', function(request, response){
    response.render('index');
})
app.post('/submit', function(request, response){
    request.session['name'] = request.body.name;
    request.session['language'] = request.body.language;
    request.session['location'] = request.body.location;
    request.session['comment'] = request.body.comment;
    response.redirect('/result');
})
app.get('/result', function(request, response){
    response.render('result', {name: request.session['name'], location: request.session['location'], language: request.session['language'], comment: request.session['comment']});
})
app.get('/clearsession', function(request, response){
    request.session.destroy();
    response.redirect('/');
})


app.listen(5000, function(){
    console.log("listening on port 5000");
});