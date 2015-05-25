// Problem 3. Min/Max of sequence
// Write a script that finds the max and min number from a sequence of numbers.

var arr = [],
    randomNumber,
    index,
    min = Number.MAX_VALUE,
    max = Number.MIN_VALUE;

// Generate an array with random numbers
for (randomNumber = 0; randomNumber <= 9; randomNumber++) {
    arr.push(Math.floor((Math.random() * 100) + 1));
}

// Find Min and Max
for (index = 0; index < arr.length; index++) {
    if (arr[index] >= max)
        max = arr[index];

    if (arr[index] <= min)
        min = arr[index];
}

console.log('Sample array: ' + arr);
console.log('Min = ' + min);
console.log('Max = ' + max);