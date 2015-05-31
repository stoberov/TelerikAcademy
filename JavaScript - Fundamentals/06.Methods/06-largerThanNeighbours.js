// Problem 6. Larger than neighbours
// Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

var sampleOne = [4, 6, 4],
    sampleTwo = [3, 2, 1],
    sampleThree = [, 2, 1],
    positionToCheck = 1;

console.log(checkIfBigger(sampleOne, positionToCheck)); // True
console.log(checkIfBigger(sampleTwo, positionToCheck)); // False
console.log(checkIfBigger(sampleThree, positionToCheck)); // No left neighbour

function checkIfBigger(arr, position) {
    if (arr[position - 1] == undefined && arr[position + 1] == undefined)
        return 'No neighbours';

    if (arr[position - 1] == undefined)
        return 'No left neighbour';

    if (arr[position + 1] == undefined)
        return 'No right neighbour';

    return ((arr[position] > arr[position + 1]) && (arr[position] > arr[position - 1]));
}