// Problem 2. Multiplication Sign
// Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators.

console.log('5 * 2 * 2 = ' + checkSign(5, 2, 2));
console.log('0 * (-2.5) * 4 = ' + checkSign(0, -2.5, 4));
console.log('(-1) * (-0.5) * (-5.1) = ' + checkSign(-1, -0.5, -5.1));

function checkSign(a, b, c) {
    if (a == 0 || b == 0 || c == 0) {
        return 0;
    }
    else {
        if (a > 0) {
            if (b > 0) {
                if (c > 0)
                    return '+';
                else
                    return '-';
            }
            else {
                if (c > 0)
                    return '-';
                else
                    return '+';
            }
        }
        else {
            if (b > 0) {
                if (c > 0)
                    return '-';
                else
                    return '+';
            }
            else {
                if (c > 0)
                    return '+';
                else
                    return '-';
            }
        }
    }
}