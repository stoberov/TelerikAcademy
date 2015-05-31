// Problem 5. Appearance count
// Write a function that counts how many times given number appears in given array.
// Write a test function to check if the function is working correctly.

var sample = [2, 2, 2, 10, 11, 12, 2, 2, 2],
    numberToCheck = 2,
    expectedAppearances = 6;// expected to appear six times

console.log(countAppearances(sample, numberToCheck)); // 6
console.log(checkAnswer(sample, numberToCheck, expectedAppearances)); // True

function countAppearances(arr, number) {
    var count = 0;

    for (var index = 0; index <= arr.length - 1; index += 1) {
        if (arr[index] == number)
            count++;
    }

    return count;
}

function checkAnswer(arr, number, expected) {
    return countAppearances(arr, number) == expected;
}