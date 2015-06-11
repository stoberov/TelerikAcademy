// Problem 5. Youngest person
// Write a function that finds the youngest male person in a given array of people and prints his full name
// Use only array methods and no regular loops (for, while)
// Use Array#find

var arrayPeople = [
    {
        firstname: 'Stannis',
        lastname: 'Targaryen',
        age: 44,
        gender: 'male'
    },
    {
        firstname: 'Sansa',
        lastname: 'Lannister',
        age: 66,
        gender: 'female'
    },
    {
        firstname: 'Margaery',
        lastname: 'Targaryen',
        age: 37,
        gender: 'female'
    },
    {
        firstname: 'Eddard',
        lastname: 'Tyrell',
        age: 72,
        gender: 'male'
    },
    {
        firstname: 'Jon',
        lastname: 'Thorne',
        age: 34,
        gender: 'male'
    },
    {
        firstname: 'Jon',
        lastname: 'Lannister',
        age: 19,
        gender: 'male'
    },
    {
        firstname: 'Daenerys',
        lastname: 'Stark',
        age: 28,
        gender: 'female'
    },
    {
        firstname: 'Arya',
        lastname: 'Clegane',
        age: 42,
        gender: 'female'
    },
    {
        firstname: 'Jaime',
        lastname: 'Payne',
        age: 16,
        gender: 'male'
    },
    {
        firstname: 'Eddard',
        lastname: 'Thorne',
        age: 12,
        gender: 'male'
    }
];

if (!Array.prototype.find) {
    Array.prototype.find = function (callback) {
        var i,
            len = this.length;

        for (i = 0; i < len; i += 1) {
            if (callback(this[i], i, this))
                return this[i];
        }
    }
}
var youngestMale = arrayPeople.filter(function (person) {
    return person.gender === 'male';
}).sort(function (personOne, personTwo) {
    return personOne.age - personTwo.age;
});

console.log(youngestMale[0]);