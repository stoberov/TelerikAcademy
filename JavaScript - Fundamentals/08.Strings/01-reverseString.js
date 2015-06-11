// Problem 1. Reverse string
//Write a JavaScript function that reverses a string and returns it.

console.log(reverseString('sample'));

function reverseString(str) {
    var reversed ='';

    for (var i = str.length - 1; i >= 0; i -= 1) {
        reversed += str[i];
    }

    return reversed;
}