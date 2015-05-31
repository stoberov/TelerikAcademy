// Problem 6. Most frequent number
// Write a script that finds the most frequent number in an array.

var sample = [4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3];

console.log(findMostFrequentNumber(sample));

function findMostFrequentNumber(arr) {
    if (arr.length == 0)
        return null;

    var temp = {},
        mostFrequentElement = arr[0],
        maxCount = 1;

    for (var i = 0; i < arr.length; i++) {
        var number = arr[i];

        if (temp[number] == null)
            temp[number] = 1;
        else
            temp[number]++;

        if (temp[number] > maxCount) {
            mostFrequentElement = number;
            maxCount = temp[number];
        }
    }

    return mostFrequentElement + ' (' + maxCount + "times)";
}