// Problem 4. Has property
// Write a function that checks if a given object contains a given property.

var phone = {
    brand: 'Sony',
    display: '4.7 inch',
    isJailBroken: false
};

console.log(checkProperty(phone, 'brand'));
console.log(checkProperty(phone, 'display'));
console.log(checkProperty(phone, 'RAM'));

function checkProperty(obj, prop) {
    for (var i in obj) {
        return i === prop;
    }
}