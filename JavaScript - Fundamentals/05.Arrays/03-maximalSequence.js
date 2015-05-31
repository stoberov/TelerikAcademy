// Problem 3. Maximal sequence
// Write a script that finds the maximal sequence of equal elements in an array.

var sample = [2, 1, 1, 2, 3, 3, 2, 2, 2, 1];

console.log(findMaxSequence(sample));

function findMaxSequence(randomArray) {
    var bestSequence = [randomArray[0]],
        tempArray = [randomArray[0]];

    for (var index = 1; index < randomArray.length; index++) {
        if (randomArray[index] !== tempArray[0]) {
            tempArray = [randomArray[index]];
        } else {
            tempArray.push(randomArray[index]);
        }

        if (tempArray.length > bestSequence.length) {
            bestSequence = tempArray;
        }
    }

    return bestSequence;
}