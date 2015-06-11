// Problem 3. Sub-string in text
// Write a JavaScript function that finds how many times a substring is contained in a given text (perform case insensitive search).

var target = 'in',
    sample = 'We are living in an yellow submarine. We don\'t have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.';

console.log(countOccurrences(sample, target)); // expected = 9

function countOccurrences(text, substring) {
    var counter = 0;

    for (var i = 0; i < text.length; i++) {
        var indexOfSubstring = text.indexOf(substring, i);

        if (indexOfSubstring != -1) {
            counter += 1;
            i = indexOfSubstring;
        }
    }

    return counter;
}