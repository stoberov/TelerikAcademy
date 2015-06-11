// Problem 3. Deep copy
// Write a function that makes a deep copy of an object. The function should work for both primitive and reference types.

var phone = {
    brand: 'Sony',
    display: '4.7 inch',
    isJailBroken: false
};

console.log(phone);
console.log(clone(phone));

function clone(originalObject) {
    if (typeof originalObject !== 'object')
        return originalObject;

    var clonedObject = {};

    for (var prop in originalObject) {
        clonedObject[prop] = clone(originalObject[prop]);
    }

    return clonedObject;
}