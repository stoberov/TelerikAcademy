// Problem 3. The biggest of Three
// Write a script that finds the biggest of three numbers. Use nested if statements.

console.log('The biggest of -2, 4 and 3 is ' + findBiggest(-2, 4, 3));
console.log('The biggest of -0.1, -0.5 and -1.1 is ' + findBiggest(-0.1, -0.5, -1.1));

function findBiggest(a, b, c) {
    if (a >= b && a >= c)
        return a;
    else if (b >= a && b >= c)
        return b;
    else
        return c;
}