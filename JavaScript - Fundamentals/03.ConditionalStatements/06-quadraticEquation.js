// Problem 6. Quadratic equation
// Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). Calculates and prints its real roots.

console.log('2 5 -3 => ' + solveQuadraticEquation(2, 5, -3));
console.log('-0.5 4 -8 => ' + solveQuadraticEquation(-0.5, 4, -8));
console.log('5 2 8 => ' + solveQuadraticEquation(5, 2, 8));

function solveQuadraticEquation(a, b, c) {
    var discriminant = (b * b) - (4 * a * c);

    if (discriminant == 0) {
        var oneDoubleRealRoot = (-b) / (2 * a);
        return 'One double real root = ' + oneDoubleRealRoot;
    }
    else if (discriminant > 0) {
        var firstRealRoot = ((-b) + Math.sqrt((b * b - 4 * a * c))) / (2 * a);
        var secondRealRoot = ((-b) - Math.sqrt((b * b - 4 * a * c))) / (2 * a);

        return 'Two real roots: ' + firstRealRoot + ' and ' + secondRealRoot;
    }
    else
        return 'No real roots';
}