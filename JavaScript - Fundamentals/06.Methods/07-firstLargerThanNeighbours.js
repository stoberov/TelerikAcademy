// Problem 7. First larger than neighbours
// Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
// Use the function from the previous exercise.

var sampleOne = [4, 6, 4],
    sampleTwo = [3, 2, 1],
    sampleThree = [1, 2, 3, 4, 3, 2, 1];

console.log(getIndexOfFirstBigger(sampleOne));
console.log(getIndexOfFirstBigger(sampleTwo));
console.log(getIndexOfFirstBigger(sampleThree));

function checkIfBigger(arr, position) {
    if (arr[position - 1] == undefined && arr[position + 1] == undefined)
        return 'No neighbours';

    if (arr[position - 1] == undefined)
        return 'No left neighbour';

    if (arr[position + 1] == undefined)
        return 'No right neighbour';

    return ((arr[position] > arr[position + 1]) && (arr[position] > arr[position - 1]));
}

function getIndexOfFirstBigger(arr) {
    for (var index = 0; index < arr.length - 1; index += 1) {
        if (checkIfBigger(arr, index) === true)
            return index;
    }

    return -1;
}