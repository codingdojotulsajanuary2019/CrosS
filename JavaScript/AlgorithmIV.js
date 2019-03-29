function gty(arr,y)
{
    var count=0;
    var newArr=[];
    for(var i=0; i<arr.length; i++)
    {
        if(y<arr[i]){
            count=count+1;
            newArr.push(arr[i]);
        }
    }
    console.log("count:"+count+newArr);
}
gty([1,2,3],1);

function minmaxavg(arr)
{
    var min=arr[0];
    var max=arr[0];
    var sum=arr[0];
    for(var i=0; i<arr.length; i++)
    {
        if(arr[i]>max)
        {
            max=arr[i];
        }
        else if(arr[i]<min)
        {
            min=arr[i];
        }
        sum=sum+arr[i];
    }
    var avg=sum/arr.length;
    var x=[min,max,avg];
    return x;
}
minmaxavg([1,2,3,4,5,6]);

function repNeg(arr)
{
    var newArr=[];
    for(var i=0; i<arr.length; i++)
    {
        if(arr[0]<0)
        {
            newArr[i]="Dojo";
        }
        else{
            newArr[i]=arr[i];
        }
    }
    return newArr;
}
repNeg([1,2,3,4,5,6,-8]);

function remVal(arr,st,end)
{
var diff=end+st+1;
for(var i=end+1; i<arr.length; i++)
    {
        var temp=arr[i-diff];
        arr[i-diff]=arr[i];
        arr[i]=temp;
    }
    arr.length=arr.length-diff;
    return arr;
}
console.log(remVal([1,2,3,4,5,6,7],2,4));
