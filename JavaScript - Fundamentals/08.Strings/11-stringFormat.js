// Problem 11. String format
// Write a function that formats a string using placeholders.
// The function should work with up to 30 placeholders and all types.

var frmt = '{0}, {1}, {0} text {2}';
console.log(format(frmt, 1, 'Pesho', 'Gosho'));

function format() {
    var args = arguments,
        placeholder = /\{[0-9]*?}/g;

    var placeholders = args[0].match(placeholder);

    var len = placeholders.length;

    for (var i = 0; i < len; i += 1) {
        args[0] = args[0].replace(placeholders[i], args[(placeholders[i].substring(1, placeholders[i].length - 1) * 1) + 1].toString());
    }

    return args[0];
}