// Problem 8. Number as words
// Write a script that converts a number in the range [0…999] to words, corresponding to its English pronunciation.

var resultHundreds,
    resultTens,
    resultOnes,
    numberAsText;

console.log('19 -> ' + convertNumberToWord(19));
console.log('98 -> ' + convertNumberToWord(98));
console.log('501 -> ' + convertNumberToWord(501));
console.log('617 -> ' + convertNumberToWord(617));

function convertNumberToWord(number) {
    numberAsText = '';

    if (number > 99) {
        resultHundreds = Math.floor(number / 100);

        switch (resultHundreds) {
            case 1:
                numberAsText += 'One hundred ';
                break;
            case 2:
                numberAsText += 'Two hundred ';
                break;
            case 3:
                numberAsText += 'Three hundred ';
                break;
            case 4:
                numberAsText += 'Four hundred ';
                break;
            case 5:
                numberAsText += 'Five hundred ';
                break;
            case 6:
                numberAsText += 'Six hundred ';
                break;
            case 7:
                numberAsText += 'Seven hundred ';
                break;
            case 8:
                numberAsText += 'Eight hundred ';
                break;
            case 9:
                numberAsText += 'Nine hundred ';
                break;
        }

        if (number % 100 != 0) {
            numberAsText += 'and ';
        }
    }

    if ((number % 100) > 19) {
        resultTens = Math.floor((number % 100) / 10);

        switch (resultTens) {
            case 2:
                numberAsText += 'Twenty ';
                break;
            case 3:
                numberAsText += 'Thirty ';
                break;
            case 4:
                numberAsText += 'Forty ';
                break;
            case 5:
                numberAsText += 'Fifty ';
                break;
            case 6:
                numberAsText += 'Sixty';
                break;
            case 7:
                numberAsText += 'Seventy ';
                break;
            case 8:
                numberAsText += 'Eighty ';
                break;
            case 9:
                numberAsText += 'Ninety ';
                break;
        }
    }

    if (((number % 100) < 10) || ((number % 100) > 19)) {
        resultOnes = number % 10;

        switch (resultOnes) {
            case 1:
                numberAsText += 'One';
                break;
            case 2:
                numberAsText += 'Two';
                break;
            case 3:
                numberAsText += 'Three';
                break;
            case 4:
                numberAsText += 'Four';
                break;
            case 5:
                numberAsText += 'Five';
                break;
            case 6:
                numberAsText += 'six';
                break;
            case 7:
                numberAsText += 'Seven';
                break;
            case 8:
                numberAsText += 'Eight';
                break;
            case 9:
                numberAsText += 'Nine';
                break;
        }
    }
    else {
        resultTens = number % 100;
        switch (resultTens) {
            case 10:
                numberAsText += 'Ten';
                break;
            case 11:
                numberAsText += 'Eleven';
                break;
            case 12:
                numberAsText += 'Twelve';
                break;
            case 13:
                numberAsText += 'Thirteen';
                break;
            case 14:
                numberAsText += 'Fourteen';
                break;
            case 15:
                numberAsText += 'Fifteen';
                break;
            case 16:
                numberAsText += 'Sixteen';
                break;
            case 17:
                numberAsText += 'Seventeen';
                break;
            case 18:
                numberAsText += 'Eighteen';
                break;
            case 19:
                numberAsText += 'Nineteen';
                break;
        }
    }

    if (number == 0) {
        return 'Zero';
    }

    return numberAsText;
}