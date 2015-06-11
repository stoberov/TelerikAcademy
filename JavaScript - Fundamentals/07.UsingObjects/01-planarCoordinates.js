// Problem 1. Planar coordinates
// Write functions for working with shapes in standard Planar coordinate system.
// Points are represented by coordinates P(X, Y)
// Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
// Calculate the distance between two points.
// Check if three segment lines can form a triangle.

/* Test */

var lineOne = createLine(createPoint(4, 3), createPoint(3, 3));
var lineTwo = createLine(createPoint(2, 1), createPoint(4, 4));
var lineThree = createLine(createPoint(4, 2), createPoint(4, 2));

if (validatePossibleTriangle(lineOne, lineTwo, lineThree)) {
    console.log('Lines can form a triangle!');
} else {
    console.log('Lines cannot form a triangle!');
}

console.log('Line One: ' + lineOne.displayLine());
console.log('Line Two: ' + lineTwo.displayLine());
console.log('Line Three: ' + lineThree.displayLine());

/* End of Test */

/* Functions */

function createPoint(x, y) {
    return {
        x: x,
        y: y
    };
}

function createLine(pointA, pointB) {
    return {
        pointA: pointA,
        pointB: pointB,
        displayLine: function () {
            return 'Line starts at point A (' + pointA.x + ', ' + pointA.y + ') and ends at point B (' + pointB.x + ', ' + pointB.y + ')';
        }
    };
}

function calculateDistance(point1, point2) {
    return parseInt(Math.abs(point1.x - point2.x) * Math.abs(point1.x - point2.x)
        + Math.abs(point1.y - point2.y) * Math.abs(point1.y - point2.y));
}

function validatePossibleTriangle(line1, line2, line3) {
    var a = calculateDistance(line1.pointA, line1.pointB);
    var b = calculateDistance(line2.pointA, line2.pointB);
    var c = calculateDistance(line3.pointA, line3.pointB);

    return (a + b > c) && (a + c > b) && (c + b > a) ? true : false;
}

/* End of Functions */