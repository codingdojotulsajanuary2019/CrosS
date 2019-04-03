function ninjaConstructor(name){
    var self = this;
    var privateSpeed = 3;
    var privateStrength = 3;
    this.name = name;
    this.health = 100;
    this.sayName = function(){
        console.log(this.name);
    }
    this.showStats = function(){
        console.log(`My Strength is: ${privateStrength}, My Speed is: ${privateSpeed}, and My Health is: ${this.health}.`);
    }
    this.drinkSake = function(){
        this.health += 10;
        console.log(`Your health is now at ${this.health} points!`);
    }
}
var ninja1 = new ninjaConstructor("Cros");
ninja1.sayName();
ninja1.showStats();
ninja1.drinkSake();