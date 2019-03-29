$(document).ready(function() {
    $('img.image').click(function(){
        console.log('hey')
        $(this).hide();
    });
    $('button').click(function(){
        console.log('refresh')
        $('img.image').show();
    })
});