function CoinChange(n)
{
    var dime = 10;
    var quarter = 25;
    var nickel = 5;
    var penny = 1;
    var dollar = 100;
    
    var Dollars = 0;
    var Pennies = 0;
    var Quarters = 0;
    var Nickels = 0;
    var Dimes = 0;
    while(n > 0)
    {
        if(n >= 100)
        {
            n = n - dollar;
            Dollars++;
        }
        if(n >= 25 && n < 100)
        {
            n = n - quarter;
            Quarters++;
        }
        if(n >= 10 && n < 25)
        {
            n = n - dime;
            Dimes++;
        }
        if(n >= 5 && n < 10)
        {
            n = n - nickel;
            Nickels++
        }
        if(n >= 1 && n < 5)
        {
            n = n - penny;
            Pennies++
        }
    }
    return(`Pennies: ${Pennies}; Nickels: ${Nickels}, Dimes: ${Dimes}, Quarters: ${Quarters}, Dollars: ${Dollars}`);
}
console.log(CoinChange(342));