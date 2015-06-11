// Problem 8. Replace tags
// Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

var testPhrase = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

console.log(replaceHyperlinks(testPhrase));

function replaceHyperlinks(str) {
    var i = 0,
        result = '',
        state = false;

    while (i < str.length) {
        if (str[i] === '<' && str[i + 1] === 'a') {
            result += '[URL';
            i += 7;
            state = true;
        }
        else if (str[i] === '>' && state) {
            result += ']';
            i += 1;
            state = false;
        }
        else if (str[i] === '<' && str[i + 1] === '/' && str[i + 2] === 'a') {
            result += '[/URL]';
            i += 4
        }
        else if (str[i] === '"') {
            str[i] = '';
            i += 1;
        }
        else {
            result += str[i];
            i += 1;
        }
    }

    return result;
}