$(document).ready(function() {
    $('img.image').hover(function(){
        console.log('hey')
        $(this).attr('src', 'jQuery.png');
    });
    $('img.image').mouseout(function(){
        console.log('hi')
        $(this).attr('src', 'bigman.gif');
    });
});