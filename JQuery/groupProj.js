$(document).ready(function(){
    console.log("document ready")

    $('button.down').click(function(){
        console.log("button press")
        $('p.down').slideDown("slow", function(){
            console.log("slide down");
        });
    });

    $('button.up').click(function(){
        console.log("button press")
        $('p.down').slideUp("slow", function(){
            console.log("slide up");
        });
    });

    $('button.toggle').click(function(){
        console.log("button press")
        $('p.toggle').slideToggle("slow", function(){
            console.log("slide toggle");
        });
    });

    $('button.after').click(function(){
        console.log("button press")
        $('p.after').after("add more text")
            console.log("after");
    });

    $('button.attr').click(function(){
        console.log("button press")
        $('p.attr').attr("style", "color:red")
            console.log("attr");
    });

});