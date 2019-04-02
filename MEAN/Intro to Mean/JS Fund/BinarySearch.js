function BinarySearch(arr, n)
{
    var start = 0;
    var end = arr.length;
    var idxmiddle  = Math.floor((start + end) /2);
    var valmiddle  = arr[Math.floor((start + end) /2)];
    
    for(var i = 0; i < 8; i++)
    {
        if(n > valmiddle)
        {
            start = idxmiddle;
            var valmiddle  = arr[Math.floor((start + end) /2)];
            var idxmiddle  = Math.floor((start + end) /2);
        }
        if(n < valmiddle)
        {
            end = idxmiddle;
            var valmiddle  = arr[Math.floor((start + end) /2)];
            var idxmiddle  = Math.floor((start + end) /2);
        }
        if(n == valmiddle)
        {
            return `Value: ${valmiddle}, Index: ${idxmiddle}.`
        }
    }
    return "-1";
}
console.log(BinarySearch([1,2,3,4,5,6,7,8,9,10,11], 9));