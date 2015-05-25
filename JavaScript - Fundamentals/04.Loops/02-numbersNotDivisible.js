// Problem 2. Numbers not divisible
// Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var N = 50;

for (var number = 1; number <= N; number++) {
    if (number % 21 != 0)
        console.log(number);
}