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
    if(request.session.count == null){
        request.session.count = 1;
    }
    else{
        request.session.count = request.session.count + 1;
    }
    response.render('index', {count: request.session.count});
});
app.get('/two', function(request, response){
    if(request.session.count == null){
        request.session.count = 2;
    }
    else{
        request.session.count = request.session.count + 2;
    }
    response.render('index', {count: request.session.count});
});
app.get('/clear', function(request, response){
    request.session.destroy();
    response.redirect('/');
})


app.listen(5000, function(){
    console.log("listening on port 5000");
});