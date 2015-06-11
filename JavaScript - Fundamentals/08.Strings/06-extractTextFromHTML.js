// Problem 6. Extract text from HTML
// Write a function that extracts the content of a html page given as text. The function should return anything that is in a tag, without the tags.

var sample = '<html><head><title>Sample site</title></head><body><div>text<div>more text</div>and more...</div>in body</body></html>'; // expected result: Sample sitetextmore textand more...in body

console.log(extractTextFromTags(sample));

function extractTextFromTags(text) {
    for (var i = 0; i < text.length; i += 1) {
        var indexStart = text.indexOf('<');
        var indexEnd = text.indexOf('>');
        text = (text.replace(text.substring(indexStart, indexEnd + 1), ''));
    }

    return text;
}