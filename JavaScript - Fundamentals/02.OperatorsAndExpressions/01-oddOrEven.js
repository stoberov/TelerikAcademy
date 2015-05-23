// Problem 1. Odd or Even
// Write an expression that checks if given integer is odd or even.

var a = 3,
    b = 2;

function checkOddOrEven(input) {
    return input % 2 == 0;
}

console.log(a + ' is even? ' + checkOddOrEven(a));
console.log(b + ' is even? ' + checkOddOrEven(b));