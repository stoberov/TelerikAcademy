// Problem 1. Make person
// Write a function for creating persons.
// Each person must have firstname, lastname, age and gender (true is female, false is male)
// Generate an array with ten person with different names, ages and genders

function createPerson(firstname, lastname, age, gender) {
    return {
        firstname: firstname,
        lastname: lastname,
        age: age,
        gender: gender
    }
}

function randomFirstName() {
    var firstname = ['Jon', 'Tyrion', 'Daenerys', 'Arya', 'Sansa', 'Petyr', 'Margaery', 'Eddard', 'Jaime', 'Stannis'];
    return firstname[Math.random() * 10 | 0];
}

function randomSecondName() {
    var secondname = ['Stark', 'Martell', 'Snow', 'Baratheon', 'Targaryen', 'Tyrell', 'Clegane', 'Lannister', 'Thorne', 'Payne'];
    return secondname[Math.random() * 10 | 0];
}

var arrayPeople = [];

for (var i = 0; i < 10; i += 1) {
    arrayPeople.push(createPerson(randomFirstName(), randomSecondName(), Math.random() * 80 | 0, Math.round(Math.random()) ? 'male' : 'female'));
}

arrayPeople.forEach(function (item) {
    console.log(item.firstname + ' ' + item.lastname + ' ' + item.age + ' ' + item.gender);
});