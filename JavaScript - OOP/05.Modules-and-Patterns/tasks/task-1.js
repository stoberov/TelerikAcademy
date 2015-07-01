/* Task Description */
/* 
 * Create a module for a Telerik Academy course
 * The course has a title and presentations
 * Each presentation also has a title
 * There is a homework for each presentation
 * There is a set of students listed for the course
 * Each student has firstname, lastname and an ID
 * IDs must be unique integer numbers which are at least 1
 * Each student can submit a homework for each presentation in the course
 * Create method init
 * Accepts a string - course title
 * Accepts an array of strings - presentation titles
 * Throws if there is an invalid title
 * Titles do not start or end with spaces
 * Titles do not have consecutive spaces
 * Titles have at least one character
 * Throws if there are no presentations
 * Create method addStudent which lists a student for the course
 * Accepts a string in the format 'Firstname Lastname'
 * Throws if any of the names are not valid
 * Names start with an upper case letter
 * All other symbols in the name (if any) are lowercase letters
 * Generates a unique student ID and returns it
 * Create method getAllStudents that returns an array of students in the format:
 * {firstname: 'string', lastname: 'string', id: StudentID}
 * Create method submitHomework
 * Accepts studentID and homeworkID
 * homeworkID 1 is for the first presentation
 * homeworkID 2 is for the second one
 * ...
 * Throws if any of the IDs are invalid
 * Create method pushExamResults
 * Accepts an array of items in the format {StudentID: ..., Score: ...}
 * StudentIDs which are not listed get 0 points
 * Throw if there is an invalid StudentID
 * Throw if same StudentID is given more than once ( he tried to cheat (: )
 * Throw if Score is not a number
 * Create method getTopStudents which returns an array of the top 10 performing students
 * Array must be sorted from best to worst
 * If there are less than 10, return them all
 * The final score that is used to calculate the top performing students is done as follows:
 * 75% of the exam result
 * 25% the submitted homework (count of submitted homeworks / count of all homeworks) for the course
 */

function solve() {
    'use strict';

    function isValidTitle(title) {
        var regex = /\s{2,}/;

        if (regex.test(title)) {
            throw new Error('Title must not contain consecutive spaces.');
        }

        if (title.charAt(0) === ' ' || title.charAt(title.length - 1) === ' ') {
            throw new Error('Title must not start or end with spaces.');
        }

        if (title.length === 0) {
            throw new Error('Title must contain at least one character.');
        }
    }

    function areValidPresentations(presentations) {
        if (presentations.length === 0) {
            throw new Error('Presentations list is empty.');
        }

        presentations.forEach(function (entry) {
            isValidTitle(entry);
        });
    }

    function isLowerCase(word) {
        return (word[0] === word[0].toLowerCase());
    }

    function isValidStudentName(name) {
        var names = name.split(' '),
            regex = /^[A-Z][a-z]*$/;

        if (names.length === 1) {
            throw new Error('Student must not have only one name.');
        }

        if (names.length > 2) {
            throw new Error('Student must not have more than two names.');
        }

        if (typeof names[0] !== 'string' || typeof names[1] !== 'string') {
            throw new Error('Name should be a valid string.');
        }

        if (isLowerCase(names[0] || isLowerCase(names[1]))) {
            throw new Error('Names must begin with a capital letter.');
        }

        if (!regex.test(names[0]) || !regex.test(names[1])) {
            throw new Error('Invalid name format.');
        }
    }

    function isValidStudentID(students, studentID) {
        return students.some(function (student) {
            return student.id === studentID;
        });
    }

    function isValidHomeworkID(presentations, homeworkID) {
        return !(homeworkID < 1 || homeworkID > presentations.length);
    }

    function getStudentByID(studentID) {
        var studentIndex = this.students.map(function (student) {
            return student.id;
        }).indexOf(studentID);

        if (studentIndex === -1) {
            throw new Error('Student ID not found');
        }
        return this.students[studentIndex];
    }

    var examWeight = 0.75,
        homeworkWeight = 1 - examWeight;

    var Course = {
        init: function (title, presentations) {
            this.title = title;
            this.presentations = presentations;
            this.students = [];

            return this;
        },
        addStudent: function (fullname) {
            var names = fullname.split(' '),
                id;

            isValidStudentName(fullname);

            id = this.students.length + 1;

            this.students.push({
                firstname: names[0],
                lastname: names[1],
                id: id,
                submittedHomework: Object.create(null),
                examScore: 0,
                finalScore: 0
            });

            return id;
        },
        getAllStudents: function () {
            return this.students.slice();
        },
        submitHomework: function (studentID, homeworkID) {
            if (!isValidStudentID(this.students, studentID)) {
                throw new Error('Invalid student ID!');
            }
            if (!isValidHomeworkID(this.presentations, homeworkID)) {
                throw new Error('Invalid homework ID!');
            }
        },
        pushExamResults: function (results) {
            results.forEach(function (result) {
                var student = getStudentByID.call(this, result.StudentID);
                student.examScore = result.score;
            }, this);
        },
        getTopStudents: function () {
            var i,
                topTenStudents = [],
                studentsCount = this.students.length,
                studentsUpToTenCount = (studentsCount > 10 ? 10 : studentsCount);

            this.students.forEach(function (student) {
                var submittedHomeworksCount = Object.keys(student.submittedHomework).length;

                student.finalScore =
                    ((homeworkWeight * submittedHomeworksCount) / this.presentations.length) + (student.examScore * examWeight);
            });

            this.students.sort(function (firstStudent, secondStudent) {
                return secondStudent.finalScore - firstStudent.finalScore;
            });

            for (i = 0; i < studentsUpToTenCount; i += 1) {
                topTenStudents.push({
                    firstname: this.students[i].firstname,
                    lastname: this.students[i].lastname,
                    id: this.students[i].id
                });
            }

            return topTenStudents;
        }
    };

    Object.defineProperties(Course, {
        title: {
            get: function () {
                return this._title;
            },
            set: function (value) {
                isValidTitle(value);
                this._title = value;
            }
        },
        presentations: {
            get: function () {
                return this._presentations;
            },
            set: function (value) {
                areValidPresentations(value);
                this._presentations = value.map(function (presentation, index) {
                    return {
                        title: presentation,
                        id: index + 1
                    };
                });
            }
        }
    });

    return Course;
}

module.exports = solve;