// Problem 1. Format with placeholders
// Write a function that formats a string. The function should have placeholders, as shown in the example
// Add the function to the String.prototype

var phraseOne = 'Hello, there! Are you #{name}?';
var phraseTwo = 'My name is #{name} and I am #{age}-years-old';

String.prototype.format = function (options) {
    var option,
        fullString = this;

    for (option in options) {
        var placeholder = /#\{\w+}/;
        fullString = fullString.replace(placeholder, options[option]);
    }

    return fullString;
};

console.log(phraseOne.format({name: 'John'}));
console.log(phraseTwo.format({name: 'John', age: 13}));