// Problem 2. Divisible by 7 and 5
// Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

var a = 70,
    b = 80;

function isDivisible(input) {
    return input % 35 == 0;
}

console.log(a + ' is divisible? ' + isDivisible(a));
console.log(b + ' is divisible? ' + isDivisible(b));