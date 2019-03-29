function resetNeg(arr){
    for(var i = 0; i < arr.length; i++){
        if(arr[i] < 0){
            arr[i] = 0;
        }
    }
    return arr;
}
console.log(resetNeg([1,2,-1,2,-4,5]));

function mvFwd(arr){
    for(var i=1; i<arr.length; i++){
        arr[i-1] = arr[i];
    }
    arr[arr.length-1] = 0;
    return arr;
}
console.log(mvFwd([1,2,3,4]));

function revArray(arr){
    for(var i = 0; i < arr.length/2; i++){
        temp = arr[i];
        arr[i] = arr[arr.length-1-i];
        arr[arr.length-1-i] = temp;
    }
    return arr;
}
console.log(revArray([1,2,3,4]));

function repeatTwice(arr){
    var x=arr.length;
    arr.length=arr.length*2;
    for(var i=x-1; i>0; i--){
        arr[i*2]=arr[i];
    }
    for(var j=0; j<arr.length; j+=2){
        arr[j+1]=arr[j];
    }
    return arr;
}
console.log(repeatTwice([1,2,3,4]));