function ninjaConstructor(name){
    var self = this;
    var privateSpeed = 3;
    var privateStrength = 3;
    this.name = name;
    this.health = 100;
    this.sayName = function(){
        console.log(`My name is ${this.name}!`);
    }
    this.showStats = function(){
        console.log(`My Strength is: ${privateStrength}, My Speed is: ${privateSpeed}, and My Health is: ${this.health}.`);
    }
    this.drinkSake = function(){
        this.health += 10;
        console.log(`Your health is now at ${this.health} points!`);
    }
    this.punch = function(target){
        target.health -= 5;
        console.log(`${target.name} was punched by ${this.name} and lost 5 health!`);
        console.log(`${target.name}'s health is now at ${target.health}!`);
    }
    this.kick = function(target){
        target.health -= (15 * privateStrength);
        console.log(`${target.name} was kicked by ${this.name} and lost ${(15*privateStrength)} health!`);
        console.log(`${target.name}'s health is now at ${target.health}!`);
    }
}
var redNinja = new ninjaConstructor("Cros");
var blueNinja = new ninjaConstructor("Jeremy");
redNinja.sayName();
redNinja.showStats();
redNinja.drinkSake();
redNinja.punch(blueNinja);
blueNinja.punch(redNinja);
redNinja.punch(blueNinja);
redNinja.kick(blueNinja);