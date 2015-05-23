// Problem 6. Point in Circle
// Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius

// Inside
var a = 1.5,
    b = -3;

// Outside
var c = 0.9,
    d = -4.93;

function isInside(x, y) {
    // Pythagorean Theorem
    return ((x * x) + (y * y) <= (5 * 5))
}

console.log('Is Inside? ' + isInside(a, b)); // True
console.log('Is Inside? ' + isInside(c, d)); // False