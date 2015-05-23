// Problem 7. Is prime
// Write an expression that checks if given positive integer number n (n ? 100) is prime.

var a = 97,
    b = 51;

function isPrime(input) {
    if (input < 2) return false;

    // use Math.sqrt to cut by half the number of checks necessary
    for (var i = 2; i <= Math.sqrt(input); i++) {
        if (input % i == 0) return false;
    }

    return true;
}

console.log(a + ' - is prime? ' + isPrime(a));
console.log(b + ' - is prime? ' + isPrime(b));