// Problem 5. Youngest person
// Write a function that finds the youngest person in a given array of people and prints his/hers full name
// Each person has properties firstname, lastname and age.

var samplePeople = [
    createPerson('Leonardo', 'Da Vinci', 40),
    createPerson('Leonardo', 'The Ninja Turtle', 18),
    createPerson('Leonardo', 'DiCaprio', 45)
];

console.log('Youngest person is: ' + findTheYoungest(samplePeople));

function createPerson(fname, lname, age) {
    return {
        firstName: fname,
        lastName: lname,
        age: age,
        printBio: function () {
            return this.firstName + ' ' + this.lastName + ', Age ' + this.age;
        }
    };
}

function findTheYoungest(groupOfPeople) {
    var youngestPerson,
        searchAge = 100;

    for (var singlePerson in groupOfPeople) {
        if (groupOfPeople[singlePerson].age < searchAge) {
            youngestPerson = groupOfPeople[singlePerson];
            searchAge = groupOfPeople[singlePerson].age;
        }
    }

    return youngestPerson.printBio();
}