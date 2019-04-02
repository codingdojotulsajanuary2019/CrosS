console.log("Find the Honey for Winnie the Pooh!");
console.log("You can use 'move(north)' to move north etc. Just make sure to put quotations around the direction inside the move action.");
console.log("Once you think you're at the location of the honey, you can use 'pickUp()' to pick up the honey!");
console.log("You can use the 'drop()' action to drop the honey off at Winnie the Pooh's house and complete your task.");
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
    location: tigger,
    honey: false
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
    if(player.location == tigger)
    {
        console.log("The wonderful thing about Tiggers is Tiggers are wonderful things!")
    }
    if(player.location == pooh)
    {
        console.log("Oh! Visitors, please find my honey for me!")
    }            
    if(player.location == piglet)
    {
        console.log("Oh d-d-d-d-dear! I wasn't epecting company!")
    }
    if(player.location == rabbit)
    {
        console.log("I'll stomp you into tomorrow, have you seen these legs?")
    }
    if(player.location == bees)
    {
        console.log("Buuuzzzzzz!")
    }
    if(player.location == lumps)
    {
        console.log("Oh, look at all these lumps!")
    }
    if(player.location == robin)
    {
        console.log("I will shoot ye, with thy arrow!")
    }
    if(player.location == eeyore)
    {
        console.log("Man, i've been sitting for too long, let me lie down.")
    }
    if(player.location == kanga)
    {
        console.log("Rabbit thinks his legs are big? Have you seen my arms?!")
    }
    if(player.location == gopher)
    {
        console.log("There aint no trees out here anymore, I'm gonna starve!")
    }
    if(player.location == owl)
    {
        console.log("Whhoooo - Whoo - Whooooo")
    }
}
function pickUp()
{
    if(player.location == bees)
    {
        player.honey = true;
        console.log("You have picked up the honey, deliver it to it's owner!")
    }
    else{
        console.log("There is no honey at this location!");
    }
}
function drop()
{
    if(player.location == pooh && player.honey == true)
    {
        player.honey = false;
        console.log("Wow! You delivered the honey to Winnie the Pooh! Thank you!")
    }
    else if(player.location != pooh && player.honey == true)
    {
        console.log("This is not the person who wants the honey!");
    }
    else if(player.location == pooh && player.honey == false)
    {
        console.log("You don't have the honey, go find it!");
    }
    else if(player.locaiton != pooh && player.honey == false)
    {
        console.log("You don't have the honey, go find it!");
    }
}