// Problem 4. Average age of females
// Write a function that calculates the average age of all females, extracted from an array of persons
// Use Array#filter
// Use only array methods and no regular loops (for, while)

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

var averageAgeFemales = arrayPeople.filter(function (person) {
    return person.gender === 'female';
}).reduce(function (sum, person, i, arr) {
    return sum + person.age / arr.length;
}, 0);

console.log(averageAgeFemales);