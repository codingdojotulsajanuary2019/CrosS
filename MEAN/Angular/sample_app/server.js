var express = require('express');
var app = express();
var bodyParser = require('body-parser');

app.use(bodyParser.urlencoded({extended: true}));

var path = require('path');

app.use(express.static(__dirname + '/public/dist/public'));

app.set('views', path.join(__dirname, '/views'));

app.set('view engine', 'ejs');

app.get('/', function(request, response){
    response.render('index');
})

app.listen(8000, function() {
    console.log("listening on port 8000");
});