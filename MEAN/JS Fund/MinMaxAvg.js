function abc(arr)
{

    var min = 0;
    var max = 0;
    var sum = 0;
    for(var i = 0; i < arr.length; i++)
    {
        if(arr[i] < min)
        {
            min = arr[i];
        }
        if(arr[i] > max)
        {
            max = arr[i];
        }
        sum = sum + arr[i];
    }
    var avg = sum / arr.length;
    return `The minimum is ${min}, The Maximum is ${max}, The average is ${avg}`;
}
console.log(abc([1, -2, 9, 4]));