// Problem 6. Group people
// Write a function that groups an array of persons by first letter of first name and returns the groups as a JavaScript Object
// Use Array#reduce
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

var resultGroup = arrayPeople.reduce(function (arr, person) {
    var prop = person.firstname[0].toLowerCase();

    if (arr[prop])
        arr[prop].push(person);
    else {
        arr[prop] = [];
        arr[prop].push(person);
    }

    return arr;
}, {});

console.log(JSON.stringify(resultGroup, null, '\t'));