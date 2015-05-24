// Problem 4. Sort 3 numbers
// Sort 3 real values in descending order. Use nested if statements.
// Note: Don’t use arrays and the built-in sorting functionality.

console.log('5 1 2 => ' + sortNumbersDesc(5, 1, 2));
console.log('-2 4 3 => ' + sortNumbersDesc(-2, 4, 3));
console.log('-1.1 -0.5 -0.1 => ' + sortNumbersDesc(-1.1, -0.5, -0.1));

function sortNumbersDesc(a, b, c) {
    if (a > b) {
        if (a > c) {
            if (b > c)
                return a + ' ' + b + ' ' + c;
            else
                return a + ' ' + c + ' ' + b;
        }
        else
            return c + ' ' + a + ' ' + b;
    }
    else if (b > c) {
        if (a > c)
            return b + ' ' + a + ' ' + c;
        else
            return b + ' ' + c + ' ' + a;
    }
    else
        return c + ' ' + b + ' ' + a;
}