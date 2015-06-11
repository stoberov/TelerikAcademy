// Problem 3. Underage people
// Write a function that prints all underaged persons of an array of person
// Use Array#filter and Array#forEach
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

var printUnderaged = arrayPeople.filter(function (person) {
    return person.age < 18;
});

printUnderaged.forEach(function (item) {
    console.log(item.firstname + ' ' + item.lastname + ' ' + item.age);
});