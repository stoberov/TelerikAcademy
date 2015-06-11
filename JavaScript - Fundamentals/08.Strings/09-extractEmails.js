// Problem 9. Extract e-mails
// Write a function for extracting all email addresses from given text.
// All sub-strings that match the format @… should be recognized as emails.
// Return the emails as array of strings.

var input = 'Hello, jon.snow@stark.com ! Where is hodor@stark.com ? Email him at beyond-the-wall@abv.bg';

console.log(getEmail(input));

function getEmail(text) {
    var words = text.split(' '),
        collectedEmails = [];

    for (var i = 0; i < words.length; i += 1) {
        if (words[i].indexOf('@') > 0) {
            collectedEmails.push(words[i]);
        }
    }

    return collectedEmails;
}