// Problem 2. People of age
// Write a function that checks if an array of person contains only people of age (with age 18 or greater)
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

function isLegalAge(people) {
    return people.age >= 18;
}

console.log(arrayPeople.every(isLegalAge));