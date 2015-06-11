// Problem 2. Correct brackets
// Write a JavaScript function to check if in a given expression the brackets are put correctly.
// Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

console.log(checkBrackets('((a+b)/5-d)'));  // Correct
console.log(checkBrackets(')(a+b))'));  // Incorrect

function checkBrackets(str) {
    var brackets = 0;

    for (var i = 0; i < str.length; i += 1) {
        if (str[i] === '(') {
            brackets += 1;
        } else if (str[i] === ')')
            brackets -= 1;

        if (brackets < 0) {
            return 'Incorrect'
        }
    }

    return brackets === 0 ? 'Correct' : 'Incorrect';
}