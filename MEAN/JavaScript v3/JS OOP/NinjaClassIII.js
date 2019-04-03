class Ninja {
    constructor(name){
        this.name = name;
        this.health = 100;
        this.speed = 3;
        this.strength = 3;
        }
        sayName(){
            console.log(`My name is ${this.name}!`);
        }
        showStats(){
            console.log(`My name is ${this.name}, My strength is ${this.strength}, My speed is ${this.speed}, and My Health is ${this.health}!`);
        }
        drinkSake(){
            this.health += 10;
            console.log(`I just increased my health by 10 points! Now my health is ${this.health} points!`);
        }
}

class Sensei extends Ninja{
    constructor(name, wisdom=10){
        super(name);
        this.health = 200;
        this.strength = 10;
        this.speed = 10;
        this.wisdom = wisdom;
    }
    speakWisdom(){
        super.drinkSake();
        console.log(`For one to fully understand the spoon, one must first be the spoon.`);
    }
}
var redNinja = new Ninja("Cros");
redNinja.sayName();
redNinja.showStats();
redNinja.drinkSake();

var newSensei = new Sensei("MasterCros");
newSensei.showStats();
newSensei.speakWisdom();