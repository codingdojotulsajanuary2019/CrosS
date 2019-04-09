var express = require('express');
var app = express();
var bodyParser = require('body-parser');

var session = require('express-session');
app.use(session({
    secret: 'keyboardkitteh',
    resave: false,
    saveUninitialized: true,
    cookie: {maxAge: 60000}
}))

app.use(bodyParser.urlencoded({extended: true}));

app.use(express.static(__dirname + "/static"));
app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');

app.get('/', function(request, response){
    response.render('index', {title: "My Express Project"});
});
app.post('/adduser', function(request, response){
    console.log("POST DATA \n\n", request.body);
    response.redirect("/");
});
app.get('/users/:id', function(request, response){
    console.log('The user id requested is:', request.params.id);
    response.send("You requested the user with id:" + request.params.id);
})

app.listen(5000, function(){
    console.log("listening on port 5000");
});