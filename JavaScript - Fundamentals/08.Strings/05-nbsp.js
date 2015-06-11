// Problem 5. nbsp
// Write a function that replaces non breaking white-spaces in a text with &nbsp;

console.log(replaceWhitespaces('This   is    a  test   phrase.'));

function replaceWhitespaces(input) {
    var replaced = [];

    for (var i = 0; i < input.length; i += 1) {
        if (input[i] === ' ') {
            replaced.push('&nbsp');
        }
        else {
            replaced.push(input[i]);
        }
    }

    return replaced.join('');
}