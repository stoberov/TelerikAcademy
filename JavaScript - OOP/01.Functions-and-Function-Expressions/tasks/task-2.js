/* Task description */
/*
 Write a function that finds all the prime numbers in a range
 1) it should return the prime numbers in an array
 2) it must throw an Error if any on the range params is not convertible to `Number`
 3) it must throw an Error if any of the range params is missing
 */

function findPrimes(from, to) {
    var primes = [],
        i,
        j,
        maxDivisor,
        isPrime;
    from = +from;
    to = +to;

    if (arguments.length < 2) {
        throw new Error;
    } else if (isNaN(from) || isNaN(to)) {
        throw new Error;
    }

    for (i = from; i <= to; i += 1) {
        maxDivisor = Math.sqrt(i);
        isPrime = true;

        if (i < 2) {
            isPrime = false;
        }

        for (j = 2; j <= maxDivisor; j += 1) {
            if (!(i % j)) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) {
            primes.push(i);
        }
    }

    return primes;
}

module.exports = findPrimes;
