$(document).ready(function(){
    console.log("connected");
    $('button').click(function(){
        console.log("Fetching");
        $.get("https://opentdb.com/api.php?amount=3", display)
        function display(data) {
            console.log(data);
            for(var x=0; x<data.results.length; x++)
            {
                console.log(data.results[x].category);
                var newtext = document.createElement('div');
                $("div").addClass("bg-light rounded p-5 container text-center text-dark col-sm-4 mb-5 d-inline-block align-top mr-4")
                newtext.innerHTML = `${data.results[x].category}`;
                $('body').append(newtext);

                var thequestion = document.createElement('p');
                thequestion.innerHTML = `${data.results[x].question}`;
                console.log(thequestion.innerHTML);
                $(newtext).append(thequestion);

            }
        }
    })
});