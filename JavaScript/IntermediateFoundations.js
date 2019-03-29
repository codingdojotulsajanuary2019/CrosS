1.
function sigma(num)
{
  var sum=0;
  for(var i=0; i<=num; i++)
    {
      sum=sum+i;
    }
  return sum;
}
console.log(sigma(10));

2.
function factorial(num)
{
  var product=1;
  for (var i=1; i<=num; i++)
    {
      product=product*i;
    }
  return product;
}
console.log(factorial(5));

3.
function fibonacci(num)
{
  var arr = [0, 1];
  for (var i = 2; i <= num; i++)
  {
    arr.push(arr[i - 2] + arr[i -1])
  }
 return arr[num]
}
console.log(fibonacci(6));

4.
function secondtolast(arr)
{
  var x=0;
  if(arr.length<2)
    {
      return "null";
    }
  else if(arr.length>=2)
    {
      x=arr[arr.length-2];
    }
  return x;
}
console.log(secondtolast([4,6,9]));

5.
function nth(arr,n)
{
  if(arr.length>=n)
    {
  console.log(arr[arr.length-n])
    }
  else if(arr.length<n)
    {
      console.log("null");
    }
}
nth([1,2,3,4,5],3);

6.
function secondbiggest(arr){
    var biggest = arr[0];
    var nextbiggest = arr[0];
        for(var i=0; i<arr.length; i++)
        {
            if(arr[i]>biggest)
            {
                nextbiggest = biggest;
                biggest = arr[i];
            }
            else if(arr[i]>nextbiggest && arr[i]!=biggest)
                nextbiggest = arr[i];
        }
      if(arr.length<=1)
        {
          return "null";
        }
      return nextbiggest;
    }
    console.log(secondbiggest([1,2,4,6,1]));

    7.
    function dupe(arr)
    {
      var x = [];
      for(var i=0; i<arr.length; i++)
        {
          x.push(arr[i]);
          x.push(arr[i]);
        }
      return x;
    }
    console.log(dupe(["code",2,3,4]));
    
fibusingrecursion.
    
function fibonacci(num) {
    if (num <= 1) return 1;
  
    return fibonacci(num - 1) + fibonacci(num - 2);
  }
  console.log(fibonacci(8));