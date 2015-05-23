// Problem 8. Trapezoid area
// Write an expression that calculates trapezoid's area by given sides a and b and height h.

var a = 8.5,
    b = 4.3,
    h = 2.7;

function findArea(a, b, h) {
    return (a + b) / 2 * h;
}

console.log(findArea(a, b, h));