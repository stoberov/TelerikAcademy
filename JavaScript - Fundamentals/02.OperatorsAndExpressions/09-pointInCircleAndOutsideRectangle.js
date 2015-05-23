// Problem 9. Point in Circle and outside Rectangle
// Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

// Sample - Yes
var a = 1,
    b = 2.5;

// Sample - No
var c = 4,
    d = 0;

function insideCircle(x, y) {
    return (Math.pow(x - 1, 2) + Math.pow(y - 1, 2)) <= Math.pow(3, 2);
}

function insideRectangle(x, y) {
    return (x <= 5 && x >= -1) && (y >= -1 && y <= 1);
}

insideCircle(a, b) && !insideRectangle(a, b) ? console.log('Yes') : console.log('No');
insideCircle(c, d) && !insideRectangle(c, d) ? console.log('Yes') : console.log('No');