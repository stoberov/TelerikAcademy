// Problem 2. Reverse number
// Write a function that reverses the digits of given decimal number.

console.log(reverseDigits(256));
console.log(reverseDigits(-123.45));

function reverseDigits(number) {
    var reversed = number.toString().split('').reverse();

    if (number < 0) {
        reversed.pop();
        reversed.unshift('-');
    }

    return reversed.join('');
}