// Problem 1. JavaScript literals
// Assign all the possible JavaScript literals to different variables.

// Problem 3. Typeof variables
// Try typeof on all variables you created.

// Problem 4. Typeof null
// Create null, undefined variables and try typeof on them.

var int = 8;
var float = Math.PI;

var boolean = 5 < 10;
var string = 'Get Up, Get Up, Balkan Superman';

var array = ['The Matrix', 'Harry Potter', 'Star Wars', 'Gladiator'];

var object = {course: 'BMW', part: 'Z3'};

var func = function () {
};

var nullValue = null;
var undefinedValue = undefined;

var variables = [int, float, boolean, string, array, object, func, nullValue, undefinedValue];

for (var index = 0; index < variables.length; index++) {
    console.log(variables[index] + ' is ' + typeof variables[index]);
}

