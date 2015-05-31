// Problem 4. Maximal increasing sequence
// Write a script that finds the maximal increasing sequence in an array.

var sample = [3, 2, 3, 4, 2, 2, 4];

console.log(findMaxIncreasingSequence(sample));

function findMaxIncreasingSequence(randomArray) {
    var maxIncreasingSequence = [randomArray[0]],
        tempArray = [randomArray[0]];

    for (var i = 1; i < randomArray.length; i++) {
        if (randomArray[i] > randomArray[i - 1]) {
            tempArray.push(randomArray[i]);
        } else {
            tempArray = [randomArray[i]];
        }

        if (tempArray.length > maxIncreasingSequence.length) {
            maxIncreasingSequence = tempArray;
        }
    }

    return maxIncreasingSequence;
}