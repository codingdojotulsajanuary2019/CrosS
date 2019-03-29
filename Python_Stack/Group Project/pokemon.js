$(document).ready(function(){
    for(var i = 1; i <145; i++){
            $('div.pokemon').append(`<img value=${i} src="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/shiny/${i}.png" alt='pokemon'>`);
    }
    $(document).on("click","img",function(){
        id = ($(this).attr('value'));
        html_str = "";

        $.ajax({
            method: 'get',
            url : "https://pokeapi.co/api/v2/pokemon/"+id,
            dataType: 'json',
            success: function(res){
                html_str += '<h2>' +res.name+ '</h2>'
                html_str += '<img class="redbox_img" src=' + res.sprites.front_default + '>'
                for(var i=0; i<res.types.length; i++) {
                    html_Str += '<h5>' +res.types[i].name+ '</h5>'
                }
                $('div.redbox').html(html_str);
            }
        })
        })
    })
       
       
       
       
       
       
       
       
       
       
//         $.ajax({
//             method: 'get',
//             url: "https://pokeapi.co/api/v2/pokemon/"+i ,
//             dataType: 'json',
            
//             success: function(res) {
//                 console.log(res);
//                 $('div.pokemon').append(`<img value=${i} src=${res.sprites.front_shiny} alt='pokemon'>`);
//         },
//         complete: function(next) {
//             console.log('in done method');
//         }
//     })
//     console.log('after the ajax method');
// }
