// Problem 5. Third bit
// Write a boolean expression for finding the bit #3 (counting from 0) of a given integer.
// The bits are counted from right to left, starting from bit #0.
// The result of the expression should be either 1 or 0.

var a = 5,
    b = 8,
    c = 5343,
    d = 62241;

function findThirdBit(input) {
    var position = 3,
        mask = 1 << position,
        result = input & mask;

    return result >> position;
}

console.log(a + ' - third bit? ' + findThirdBit(a));
console.log(b + ' - third bit? ' + findThirdBit(b));
console.log(c + ' - third bit? ' + findThirdBit(c));
console.log(d + ' - third bit? ' + findThirdBit(d));
