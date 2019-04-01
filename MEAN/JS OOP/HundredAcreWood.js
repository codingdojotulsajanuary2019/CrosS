var tigger = {character: "Tigger"};
var pooh = {character: "Winnie the Pooh"};
var piglet = {character: "Piglet"};
var bees = {character: "Bees"};
var owl = {character: "Owl"};
var robin = {character: "Christopher Robin"};
var rabbit = {character: "Rabbit"};
var gopher = {character: "Gopher"};
var kanga = {character: "Kanga"};
var eeyore = {character: "Eeyore"};
var lumps = {character: "Heffalumps"};
tigger.north = pooh;
pooh.south = tigger;
pooh.west = piglet;
pooh.east = bees;
pooh.north = robin;
piglet.east = tigger.north;
piglet.north = owl;
bees.west = tigger.north;
bees.north = rabbit;
owl.south = pooh.west;
owl.east = pooh.north;
rabbit.south = pooh.east;
rabbit.west = pooh.north;
gopher.west = bees.north;
robin.north = kanga;
robin.south = tigger.north;
robin.west = piglet.north;
robin.east = bees.north;
kanga.south = robin;
kanga.north = eeyore;
eeyore.south = kanga;
eeyore.east = lumps;
lumps.west = eeyore;

var player = {
    location: tigger
}

function move(string)
{
    if(string == "north")
    {
        if(player.location.north == undefined)
        {
            console.log("You cannot go this way!");
        }
        else{
            console.log(`You are now at ${player.location.north.character}'s House!`);
            player.location = player.location.north;
        }
    }

    else if(string == "south")
    {
        if(player.location.south == undefined)
        {
            console.log("you cannot go this way!");
        }
        else{
            console.log(`You are now at ${player.location.south.character}'s House!`);
            player.location = player.location.south;
        }
    }

    else if(string == "east")
    {
        if(player.location.east == undefined)
        {
            console.log("You cannot go this way!");
        }
        else{
            console.log(`You are now at ${player.location.east.character}'s House!`);
            player.location = player.location.east;
        }

    }

    else if(string == "west")
    {
        if(player.location.west == undefined)
        {
            console.log(`You cannot go this way!`);
        }
        else{
            console.log(`You are now at ${player.location.west.character}'s House!`);
            player.location = player.location.west;
        }
    }
}