function FizzBuzz(n)
{
    var string = "";
    for(var i = 1; i <= n; i++)
    {
        if(i % 3 == 0 && i % 5 == 0)
        {
            string += "FizzBuzz, ";
        }
        if(i % 3 == 0 && i % 5 != 0)
        {
            string += "Fizz, ";
        }
        if(i % 5 == 0 && i % 3 != 0)
        {
            string += "Buzz, ";
        }
        if(i % 3 != 0 && i % 5 != 0)
        {
            string += `${i}, `;
        }
    }
    console.log(string);
}
FizzBuzz(15);