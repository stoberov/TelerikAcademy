// Problem 1. Increase array members
// Write a script that allocates array of 20 integers and initializes each element by its index multiplied by 5. Print the obtained array on the console.

var arr = new Array(20),
    index;

for (index = 0; index < arr.length; index++) {
    arr[index] = index * 5;
}

console.log(arr);