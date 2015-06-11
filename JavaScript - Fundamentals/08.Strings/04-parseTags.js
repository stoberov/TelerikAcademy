// Problem 4. Parse tags
// You are given a text. Write a function that changes the text in all regions:
//      <upcase>text</upcase> to uppercase.
//      <lowcase>text</lowcase> to lowercase
//      <mixcase>text</mixcase> to mix casing(random)

var testPhrase = 'We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don\'t</mixcase> have <lowcase>anything</lowcase> else.';

console.log(changeText(testPhrase));

function changeText(text) {
    var i = 0,
        state = '',
        oldState = '',
        result = '';

    while (i < text.length) {
        if (text[i] === '<' && text[i + 1] === 'm') {
            i += 9;
            oldState = state;
            state = 'mix';
        }
        else if (text[i] === '<' && text[i + 1] === '/' && text[i + 2] === 'm') {
            i += 10;
            state = oldState;
            oldState = '';
        }
        else if (text[i] === '<' && text[i + 1] === 'u') {
            i += 8;
            oldState = state;
            state = 'up';
        }
        else if (text[i] === '<' && text[i + 1] === '/' && text[i + 2] === 'u') {
            i += 9;
            state = oldState;
            oldState = '';
        }
        else if (text[i] === '<' && text[i + 1] === 'l') {
            i += 9;
            oldState = state;
            state = 'low';
        }
        else if (text[i] === '<' && text[i + 1] === '/' && text[i + 2] === 'l') {
            i += 10;
            state = oldState;
            oldState = '';
        }

        // Apply transformations
        if (state === 'mix') {
            var x,
                char;
            x = Math.floor(Math.random() * 2);
            if (x === 0) {
                char = text[i].toLowerCase();
            }
            else {
                char = text[i].toUpperCase();
            }

            result += char;
            i += 1;
        }
        else if (state === 'up') {
            result += text[i].toUpperCase();
            i += 1;
        }
        else if (state === 'low') {
            result += text[i].toLowerCase();
            i += 1;
        }
        else {
            result += text[i];
            i += 1;
        }
    }

    return result;
}