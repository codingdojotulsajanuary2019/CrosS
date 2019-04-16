1.
var myString: string;
// I can assign myString like this:
myString = "Bee stinger";
// Why is there a problem with this? What can I do to fix this?
myString = 9;
//well there isnt much you can do if you want to keep this a type of string aside from spelling out 'Nine'. Or just taking the typing off entirely. OR you could just asign the '9' to a new vaiable.

2.
function sayHello(name: string){
return `Hello, ${name}!`;
}
// This is working great:
console.log(sayHello("Kermit"));
// Why isn't this working? I want it to return "Hello, 9!"
console.log(sayHello(9));
//change the type to number if you want to return a number, or put the number 9 in quotations to make it a string type.


function fullName(firstName: string, lastName: string, middleName: string){
let fullName = `${firstName} ${middleName} ${lastName}`;
return fullName;
}
// This works:
console.log(fullName("Mary", "Moore", "Tyler"));
// What do I do if someone doesn't have a middle name?
console.log(fullName("Jimbo", "Jones", null));
// set the middle name to 'null'.


interface Student {
firstName: string;
lastName: string;
belts: number;
}
function graduate(ninja: Student){
return `Congratulations, ${ninja.firstName} ${ninja.lastName}, you earned ${ninja.belts} belts!`;
}
const christine = {
firstName: "Christine",
lastName: "Yang",
belts: 2
}
const jay = {
firstName: "Jay",
lastName: "Patel",
belt: 4
}
// This seems to work fine:
console.log(graduate(christine));
// This one has problems:
console.log(graduate(jay));
// youre missing an 's' on the end of 'belt' (make it 'belts') so it doesnt recognize that that vaiable fits into this situation.



class Ninja {
fullName: string;
constructor(
    firstName: string,
    lastName: string){
        this.fullName = `${firstName} ${lastName}`;
    }
debug(){
    console.log("Console.log() is my friend.")
}
}
// This is not making an instance of Ninja, for some reason:
const shane = new Ninja('cros', 'sikes');
// Since I'm having trouble making an instance of Ninja, I decided to do this:
const turing = {
fullName: "Alan Turing",
firstName: "Alan",
lastName: "Turing"
}
// Now I'll make a study function, which is a lot like our graduate function from above:
function study(programmer){
return `Ready to whiteboard an algorithm, ${programmer.fullName}?`
}
// Now this has problems:
console.log(study(turing));
//on ninja, you needed to set 'Ninja()' to 'new Ninja(fname, lname)'.
//turing was never set to a ninja so you couldnt take in a ninja as an argument.




var increment = x => x + 1;
// This works great:
console.log(increment(3));
var square = x => (x * x);
// This is not showing me what I want:
//should be now
console.log(square(4));
// This is not working:
//is now
var multiply = (x, y) => (x * y);
// Nor is this working:
var math = (x, y) => {let sum = x + y;}
var product = (x, y) => {let product = x * y};
//think thats fixed
let difference = Math.abs(x-y);
return [sum, product, difference];
//you need to put this all in a function if your intention is to do all of it at once, which, i assume you are trying to do considering the return statement.



class Elephant {
constructor(public age: number){}
birthday = function(){
    this.age++;
}
}
const babar = new Elephant(8);
setTimeout(babar.birthday, 1000)
setTimeout(function(){
console.log(`Babar's age is ${babar.age}.`)
}, 2000)
// Why didn't babar's age change? Fix this by using an arrow function in the Elephant class.
//you never called the birthday function, so it didnt change because it is not his birthday!