// Problem 2. Lexicographically comparison
// Write a script that compares two char arrays lexicographically (letter by letter).

var firstArray = randomString().split(''),
    secondArray = randomString().split(''),
    areEqual = true;

console.log(firstArray);
console.log(secondArray);

if (firstArray.length == secondArray.length) {
    for (var index = 0; index < firstArray.length; index++) {
        if (firstArray[index] != secondArray[index]) {
            areEqual = false;
            break;
        }
    }

    console.log('First Array equals Second Array? ' + areEqual);
}
else {
    console.log('The two arrays are not of the same length, so they are not lexicographically equal.');
}

function randomString() {
    var randomPhrase = '',
        possibleChars = "ABC";

    // Generate a random string between 3 and 5 characters
    for (var i = 0; i < Math.floor(Math.random() * (5 - 3 + 1) + 3); i++)
        randomPhrase += possibleChars.charAt(Math.floor(Math.random() * possibleChars.length));

    return randomPhrase;
}