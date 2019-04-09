var express = require("express");
var app = express();

app.use(express.static(__dirname + "/static"));
app.set('views', __dirname + '/views');
app.set('view engine', 'ejs');

app.get('/cars', function(request, response){
    response.render('cars');
})
app.get('/cats', function(request, response){
    response.render('cats');
})



app.get('/cat/joe', function(request, response){
    var cats_array = [
    {name: "Joe", age: 2, food: "Kibbles", sleep: "Under the couch"}
    ];
    response.render('catinfo', {cats: cats_array});
})
app.get('/cat/sam', function(request, response){
    var cats_array2 = [
    {name: "Sam", age: 4, food: "Meow Mix", sleep: "On the couch"}
    ];
    response.render('catinfo', {cats: cats_array2});
})
app.get('/cat/jim', function(request, response){
    var cats_array3 = [
    {name: "Jim", age: 1, food: "Fancy Feast", sleep: "In the Window Sill"}
    ];
    response.render('catinfo', {cats: cats_array3});
})



app.get('/cars/new', function(request, response){
    response.render('form');
})

app.listen(8000, function(){
    console.log("listening on port 8000");
});