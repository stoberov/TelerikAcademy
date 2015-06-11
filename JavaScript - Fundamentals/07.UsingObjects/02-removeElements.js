// Problem 2. Remove elements
// Write a function that removes all elements with a given value. Attach it to the array type.

Array.prototype.remove = function (element) {
    var clearedArray = [];

    for (var i = 0; i < this.length; i += 1) {
        if (this[i] !== element) {
            clearedArray.push(this[i]);
        }
    }

    return clearedArray;
};

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

console.log(arr.remove(1)); // Expected: arr = [2,4,3,4,111,3,2,'1'];