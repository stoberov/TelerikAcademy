// Problem 4. Third digit
// Write an expression that checks for given integer if its third digit (right-to-left) is 7.

var a = 5,
    b = 9703,
    c = 777877;

function isSeven(input) {
    return parseInt(input / 100) % 10 == 7;
}

console.log(a + ' - third digit 7? ' + isSeven(a));
console.log(b + ' - third digit 7? ' + isSeven(b));
console.log(c + ' - third digit 7? ' + isSeven(c));
