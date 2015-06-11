// Problem 12. Generate list
// Write a function that creates a HTML <ul> using a template for every HTML <li>.
// The source of the list should be an array of elements.
// Replace all placeholders marked with –{…}– with the value of the corresponding property of the object.

var template = '<strong>-{name}-</strong> <span>-{age}-</span>';

function generateList(template, people) {
    var result = '<ul>';

    for (var i = 0; i < people.length; i += 1) {
        result += '<li>';
        result += template.replace('-{name}-', people[i]['name']).replace('-{age}-', people[i]['age']);
        result += '</li>';
    }

    return result + '</ul>';
}

var people = [
    {name: 'Jon Snow', age: 18},
    {name: 'Arya Stark', age: 14},
    {name: 'Tyrion Lannister', age: 32}
];

function htmlGenerator() {
    console.log(generateList(template, people));
}

htmlGenerator();