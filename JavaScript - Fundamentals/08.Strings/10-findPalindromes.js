// Problem 10. Find palindromes
// Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".

var str = 'ABBA, ABBC, lamel, lamal, exxe, exe, exex';

console.log(checkForPalindromes(str));

function checkForPalindromes(input) {
    var words = input.split(','),
        palindromes = [];

    for (var i = 0; i < words.length; i += 1) {
        words[i] = words[i].trim();

        if (isPalindrome(words[i])) {
            palindromes.push(words[i]);
        }
    }

    return palindromes;
}

function isPalindrome(str) {
    return str === reverseString(str);
}

function reverseString(str) {
    return str.split('').reverse().join('');
}