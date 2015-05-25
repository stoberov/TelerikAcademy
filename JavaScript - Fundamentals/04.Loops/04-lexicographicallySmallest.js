// Problem 4. Lexicographically smallest
// Write a script that finds the lexicographically smallest and largest property in document, window and navigator objects.

// Open this html file in browser and inspect the console to see result.

console.log('Largest in Document = ' + findLargest(document));
console.log('Smallest in Document = ' + findSmallest(document));

console.log('Largest in Window = ' + findLargest(window));
console.log('Smallest in Window = ' + findSmallest(window));

console.log('Largest in Navigator = ' + findLargest(navigator));
console.log('Smallest in Navigator = ' + findSmallest(navigator));

function findLargest(object) {
    var largest = 'A';

    for (var property in object) {
        if (property > largest)
            largest = property
    }

    return largest;
}

function findSmallest(object) {
    var smallest = 'z';

    for (var property in object) {
        if (property < smallest)
            smallest = property
    }

    return smallest;
}