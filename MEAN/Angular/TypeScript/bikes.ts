class Bike {
    price: number;
    maxSpeed: number;
    miles: number;
    constructor(price: number, maxSpeed: number, miles: number) {
        this.price = price;
        this.maxSpeed = maxSpeed;
        this.miles = miles;
    }
    ride() {
        console.log('riding...');
        this.miles = this.miles + 10;
        console.log(`Your miles have increased by 10! You are now at ${this.miles} miles!`)
        return this.miles;
    }
    displayInfo() {
        console.log(`Miles: ${this.miles}, Price: ${this.price}, Max Speed: ${this.maxSpeed}`);
        return `Miles: ${this.miles}, Price: ${this.price}, Max Speed: ${this.maxSpeed}`;
    }
    reverse() {
        console.log('reversing...');
        this.miles = this.miles - 5;
        console.log(`Your miles have decreased by 5! You are now at ${this.miles} miles!`);
        return this.miles;
    }
}

let bike = new Bike(100, 35, 400);

bike.ride();
bike.ride();
bike.ride();
bike.reverse();
bike.displayInfo();