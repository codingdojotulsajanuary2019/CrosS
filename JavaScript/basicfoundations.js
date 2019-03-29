function oneTo255() {
  var arr = [];
  
  for (var i=1; i<=255; i++)
    {
      arr.push(i);
    }
   return arr;
}

console.log(oneTo255())



 function sum (){
   var total = 0;
   
   for (var i=1; i<=1000; i++)
     {
       if (i%2 === 0)
       {
         total = total + i;
       }
     
    }
   return total;
 }
   
console.log(sum());


 function oddsum (){
   var total = 0;
   
   for (var i=1; i<=5000; i++)
     {
       if (i%2 !== 0)
       {
         total = total + i;
       }
     
    }
   return total;
 }
   
console.log(oddsum());


function ittarr(arr) 
  {
    var sum = 0;
    
    for (var i=0; i<arr.length; i++)
    {
      sum = sum + arr[i];
    }
    return sum;
  }

console.log(ittarr([1,2,3,4,5]));


function returnMax(arr)
  {
    var max = arr[0];
    
    for (var i=0; i<arr.length; i++)
      {
        if(arr[i] > max)
          {
            max = arr[i];
          }
      }
    return max;
  }


console.log(returnMax([-1,-5,-3,-7]));


function avg(arr)
  {
    var sum = 0;
    
    for (var i=0; i < arr.length; i++)
      {
        sum = sum + arr[i];
      }
 return sum/arr.length;
    
  }

console.log(avg([1,2,3,4,5]));




function returnOddarr(arr)
  {
    var newArr =[];
    
    for(var i=0; i<arr.length; i++)
        {
          if(arr[i] % 2 !== 0)
              {
                newArr.push(arr[i]);
              }
        }
    return newArr;
  }

console.log(returnOddarr([1,2,3,4,5,6,7,8,9]))



function greaterThanY(arr,y)
  {
    var count = 0;
    
    for (var i=0; i<arr.length; i++)
      {
        if (arr[i]>y)
          {
            count = count + 1;
          }
      }
    return count;
  }

console.log(greaterThanY([1,2,3,4,5,6,7,8,9],3));



function squared(arr)
  {
    for(var i=0; i<arr.length; i++)
        {
          arr[i] = arr[i] * arr[i];
        }
    
    return arr;
  }

console.log(squared([1,2,3,4,5]));



function noNegs(arr)
  {
    for(var i=0; i<arr.length; i++)
        {
          if(arr[i] < 0)
              {
                arr[i] = 0;
              }
        }
    return arr;
  }

console.log(noNegs([-4,1,-3,4,-5]));



function maxMinAvg(arr)
  {
    var max = arr[0];
    var min = arr[0];
    var sum = 0;
    
    for(var i=0; i<arr.length; i++)
        {
          if(arr[i] > max)
              {
                max = arr[i];
              }
          if(arr[i] < min)
              {
                min = arr[i];
              }
          
          sum = sum + arr[i];
          
        }
    
    var newArr = [max,min,(sum/arr.length)];

      
    return newArr;
  }

console.log(maxMinAvg([1,2,3,4,5]));


function swap(arr){
  var temp = arr[0];
  var x = arr[arr.length-1];
  var y = temp;
  
 arr[0] = x;
 arr[arr.length-1]= temp;
  
 return arr;
}

console.log(swap([1,2,3,4,5]));


function numToString(arr)
  {
    for(var i=0; i<arr.length; i++)
        {
          if(arr[i] < 0)
             {
               arr[i]='Dojo';
             }
          
        }
    return arr;
  }

console.log(numToString([-1,2,-4,3,-2,-5]));


