/* Task Description */
/* 
 Create a function constructor for Person. Each Person must have:
 *	properties `firstname`, `lastname` and `age`
 *	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
 *	age must always be a number in the range 0 150
 *	the setter of age can receive a convertible-to-number value
 *	if any of the above is not met, throw Error
 *	property `fullname`
 *	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
 *	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
 *	it must parse it and set `firstname` and `lastname`
 *	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
 *	all methods and properties must be attached to the prototype of the Person
 *	all methods and property setters must return this, if they are not supposed to return other value
 *	enables method-chaining
 */
function solve() {
    var Person = (function () {

        // Function constructor
        function Person(fname, lname, age) {
            this.firstname = fname;
            this.lastname = lname;
            this.age = age;
        }

        // Create properties
        Object.defineProperty(Person.prototype, 'firstname', {
            get: function () {
                return this._firstname;
            },
            set: function (value) {
                validateName(value);

                this._firstname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'lastname', {
            get: function () {
                return this._lastname;
            },
            set: function (value) {
                validateName(value);

                this._lastname = value;
            }
        });

        Object.defineProperty(Person.prototype, 'fullname', {
            get: function () {
                return this.firstname + ' ' + this.lastname;
            },
            set: function (value) {
                var names = value.split(' ');

                this.firstname = names[0];
                this.lastname = names[1];
            }
        });

        Object.defineProperty(Person.prototype, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                validateAge(value);

                this._age = value;
            }
        });

        // Attach method
        Person.prototype.introduce = function () {
            return 'Hello! My name is ' + this.firstname + ' ' + this.lastname +
                ' and I am ' + this.age + '-years-old';
        };

        // Extra functions
        function validateName(name) {
            var allowedCharacters = /^[a-zA-Z]+$/,
                minLength = 3,
                maxLength = 20;

            if (!allowedCharacters.test(name)) {
                throw new Error('Name should contain only Latin characters');
            }

            if (name.length < minLength) {
                throw new Error('Name should contain at least ' + minLength + ' characters');
            }

            if (name.length > maxLength) {
                throw new Error('Name should contain less than ' + maxLength + ' characters');
            }

            return true;
        }

        function validateAge(age) {
            var minAge = 0,
                maxAge = 150;

            age = +age;

            if (age !== Number(age) || age.toString() === '') {
                throw new Error('Age must be a valid number');
            }

            if (age < minAge) {
                throw new Error('Age should be above ' + minAge);
            }

            if (age > maxAge) {
                throw new Error('Age should be under ' + minAge);
            }

            return true;
        }

        return Person;
    }());

    return Person;
}

module.exports = solve;