// Problem 7. Parse URL
// Write a script that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
// Return the elements in a JSON object.

var testURL = 'http://telerikacademy.com/Courses/Courses/Details/239';
console.log(parseURL(testURL));

function parseURL(url) {
    var startIndex = 0,
        endIndex = url.indexOf(':'),
        parsedUrl = {};

    parsedUrl.protocol = url.substring(startIndex, endIndex);

    startIndex = endIndex + 3;
    endIndex = url.indexOf('/', startIndex);
    parsedUrl.server = url.substring(startIndex, endIndex);

    startIndex = endIndex;
    parsedUrl.resource = url.substr(startIndex, url.length);

    return parsedUrl;
}