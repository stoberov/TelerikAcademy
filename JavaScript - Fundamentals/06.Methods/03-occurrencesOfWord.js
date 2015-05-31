// Problem 3. Occurrences of word
// Write a function that finds all the occurrences of word in a text.
// The search can be case sensitive or case insensitive.
// Use function overloading.

var sampleSong = 'I have a blue house with a blue window. Blue is the colour of all that I wear. Blue are the streets and all the trees are too. I have a girlfriend and she is so blue. Blue are the people here that walk around, Blue like my corvette, it\'s standing outside. Blue are the words I say and what I think. Blue are the feelings that live inside me.';

console.log(countOccurrences());
console.log(countOccurrences(sampleSong));
console.log(countOccurrences('Blue'));
console.log(countOccurrences(sampleSong, 'Blue')); // 6 times
console.log(countOccurrences(sampleSong, 'blue')); // 3 times


function countOccurrences(text, word) {
    switch (arguments.length) {
        case 0:
            return 'No Text and No Word';
        case 1:
            return 'No Text or Word';
        default:
            var arr = text.split(word);
            return arr.length - 1;
    }
}


