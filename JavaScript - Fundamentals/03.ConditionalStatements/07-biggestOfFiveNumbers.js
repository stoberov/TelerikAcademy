// Problem 7. The biggest of five numbers
// Write a script that finds the greatest of given 5 variables. Use nested if statements.

console.log('5 2 2 4 1 => ' + findBiggestValue(5, 2, 2, 4, 1));
console.log('-3 -0.5 -1.1 -2 -0.1 => ' + findBiggestValue(-3, -0.5, -1.1, -2, -0.1));

function findBiggestValue(a, b, c, d, e) {
    var biggestValue = a;

    if (biggestValue < b) {
        biggestValue = b;
    }

    if (biggestValue < c) {
        biggestValue = c;
    }

    if (biggestValue < d) {
        biggestValue = d;
    }

    if (biggestValue < e) {
        biggestValue = e;
    }

    return biggestValue;
}