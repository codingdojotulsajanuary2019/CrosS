1.
function biggie(arr){
    for(var i=0; i<arr.length; i++){
      if(arr[i]>0){
        arr[i]="big";
      }
    }
    return arr;
  }
  console.log(biggie([1,-5,-6,-7,4,6]))

  2.
  function a(arr)
  {
    var highest=arr[0];
    var lowest=arr[0];
    for(var i=0; i<arr.length; i++)
      {
        if(arr[i]>highest)
          {
            highest = arr[i];
          }
        else if(arr[i]<lowest)
          {
            lowest = arr[i];
          } 
      }
    console.log(lowest);
    return highest;
  }
a([1,2,3,4,5,6]);

3.
function x(arr)
  {
   console.log(arr[arr.length-2]);
   for (var i=0; i<arr.length; i++)
     {
       if(arr[i] %2 !== 0)
       {
         return (arr[i]);
       }
     }
  }
console.log (x([2,2,2,2,5,4,5,6,7]));

4.
function doublevision(arr)
  {
    var newArr=[];
    for(var i=0; i<arr.length; i++)
      {
        newArr.push(arr[i] * 2);
      }
    return newArr;
  }
(doublevision([2,4,6]));

5.
function positives(arr)
{
 var count=0;
 for(var i=0; i<arr.length; i++)
   {
     if(arr[i] > 0)
       {
         count = count + 1;
       }
   }
  arr[arr.length-1] = count;
  return arr;
}
console.log(positives([-1,2,-3,-4,5,6]));

6.
function threeinarow(arr)
{
  for(var i=0; i<arr.length; i++)
    {
      if(arr[i] %2 ===0)
        {
          if(arr[i+1] %2 ===0)
            {
              if(arr[i+2] %2 ===0)
                {
                  console.log("Even More So!")
                }
            }
        }
      else if(arr[i] %2 !==0)
        {
          if(arr[i+1] %2 !==0)
            {
              if(arr[i+2] %2 !==0)
                {
                  console.log("That's Odd!")
                }
            }
        }
    }
}
threeinarow([1,2,3,4,5,7,5,8,5,6,8,2]);

7.
function increment(arr)
{
  for(var i=0; i<arr.length; i++)
    {
      if(i %2 !==0)
        {
          arr[i] = arr[i] + 1;
        }
      console.log(arr[i]);
    }
  return arr;
}
increment([1,2,3,4,5]);

8.
function x(arr)
{
  for(var i=arr.length-1; i>0; i--)
    {
     arr[i]=arr[i-1].length;
    }
  return arr;
}
console.log(x(["hello","hi","whatsup","hey"]));

9.
function addseven(arr)
{
  var newArr=[];
  for(var i=0; i<arr.length; i++)
    {
     newArr.push(arr[i] + 7);
    }
  console.log(newArr);
}
addseven([1,2,5,-7]);

10.
function reverse(arr)
{
  var x = 0;
  for(var i=1; i<arr.length-2; i++, x++)
    {
     var temp = arr[x]
     arr[x] = arr[arr.length-i];
     arr[arr.length-i] = temp;
     console.log(arr);
    }
    return arr;
}
reverse([1,7,3,4,5,6,8]);

11.
function outlook(arr)
{
  var newArr = [];
  for(var i = 0; i < arr.length; i++)
    {
      if(arr[i]>0)
        {
          newArr[i] = -arr[i];
        }
      else if(arr[i]<0){
        newArr.push(arr[i]);
      }
    }
  return newArr;
}
console.log(outlook([1,-1,2,5,-5,6]));

12.
function hungry(arr)
{
  var x = 0;
  for(var i = 0; i < arr.length; i++)
    {
      if(arr[i] === "food")
      {
        console.log("yummy");
        x =x + 1;
      }
    }
  if(x === 0)
        {
          console.log("I'm Hungry");
        }
}
hungry([1,2,7]);

13.
function swap(arr)
{
  var x = arr[0];
  arr[0] = arr[arr.length-1];
  arr[arr.length-1] = x;
  var temp = arr[2];
  arr[2] = arr[arr.length-3];
  arr[arr.length-3]= temp;
  console.log(arr);
}
swap([1,2,3,4,5,6,7]);

14.
function scalearray(arr, num)
{
  for(var i=0; i<arr.length; i++)
    {
      arr[i] = arr[i]*num;
    }
  return arr;
}
console.log(scalearray([1,2,3,4,5,6],4));