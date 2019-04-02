// Notice that displayName is a function that takes in 1 parameter (this is the data that comes back from the API)
$(document).ready(function(){
  console.log("connected");
  $('button').click(function(){
    console.log("Fetching");
    $.get("https://api.github.com/users/ccsikes", displayName)
    function displayName(data) {
      console.log(data.name);
      $('h1').html(data.name);
    }
  })
});