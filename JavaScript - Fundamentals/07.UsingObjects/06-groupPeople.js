// Problem 6. Group People
// Write a function that groups an array of people by age, first or last name.
// The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
// Use function overloading (i.e. just one function)

/* Test */

var samplePeople = [
    {
        firstname: 'Harry',
        lastname: 'Potter',
        age: 20
    },
    {
        firstname: 'Leonardo',
        lastname: 'The Ninja Turtle',
        age: 18
    },
    {
        firstname: 'Doctor',
        lastname: 'Who',
        age: 995
    }
];

var testAge = groupPeople(samplePeople, 'age');

for (var i in testAge) {
    console.log(testAge[i].Key);
}

var testLastName = groupPeople(samplePeople, 'lastname');

for (var i in testLastName) {
    console.log(testLastName[i].Key);
}

var testFirstName = groupPeople(samplePeople, 'firstname');

for (var i in testFirstName) {
    console.log(testFirstName[i].Key);
}

/* End of Test */

function groupPeople(arr, criteria) {
    var endArr = [];
    var uniqueKeys = [];
    var groupedArr = [];

    if (criteria === 'age') {

        for (var i = 0; i < arr.length; i += 1) {
            var repeated = false;

            for (var j = 0; j < uniqueKeys.length; j += 1) {
                if (arr[i].age === arr[j].age) {
                    repeated = true;
                    break;
                }
            }

            if (!repeated) {
                uniqueKeys.push(arr[i]);
            }
        }

        for (var i = 0; i < uniqueKeys.length; i += 1) {
            var tempArr = [];

            for (var j = 0; j < arr.length; j += 1) {
                if (uniqueKeys[i].age === arr[j].age) {
                    tempArr.push(arr[j]);
                }
            }

            groupedArr.push(tempArr);
        }

        for (var i = 0; i < groupedArr.length; i += 1) {
            endArr.push({
                Key: groupedArr[i][0].age,
                Value: groupedArr[i]
            });
        }
    }
    else if (criteria === 'firstname') {

        for (var i = 0; i < arr.length; i += 1) {
            var repeated = false;

            for (var j = 0; j < uniqueKeys.length; j += 1) {
                if (arr[i].firstname === arr[j].firstname) {
                    repeated = true;
                    break;
                }
            }

            if (!repeated) {
                uniqueKeys.push(arr[i]);
            }
        }

        for (var i = 0; i < uniqueKeys.length; i += 1) {
            var tempArr = [];

            for (var j = 0; j < arr.length; j += 1) {
                if (uniqueKeys[i].firstname === arr[j].firstname) {
                    tempArr.push(arr[j]);
                }
            }
            groupedArr.push(tempArr);
        }

        for (var i = 0; i < groupedArr.length; i += 1) {
            endArr.push({
                Key: groupedArr[i][0].firstname,
                Value: groupedArr[i]
            });
        }
    }
    else if (criteria === 'lastname') {

        for (var i = 0; i < arr.length; i += 1) {
            var repeated = false;

            for (var j = 0; j < uniqueKeys.length; j += 1) {
                if (arr[i].lastname === arr[j].lastname) {
                    repeated = true;
                    break;
                }
            }

            if (!repeated) {
                uniqueKeys.push(arr[i]);
            }
        }

        for (var i = 0; i < uniqueKeys.length; i += 1) {
            var tempArr = [];

            for (var j = 0; j < arr.length; j += 1) {
                if (uniqueKeys[i].lastname === arr[j].lastname) {
                    tempArr.push(arr[j]);
                }
            }
            groupedArr.push(tempArr);
        }

        for (var i = 0; i < groupedArr.length; i += 1) {
            endArr.push({
                Key: groupedArr[i][0].lastname,
                Value: groupedArr[i]
            });
        }
    }
    else {
        return 'Wrong criteria';
    }

    return endArr;
}
