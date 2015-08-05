/* globals $ */

/*
 Create a function that takes an id or DOM element and:
 */

function solve() {
    return function (selector) {
        var element,
            allButtons,
            i,
            buttonsLength,
            currentButton;

        if (typeof  selector === 'string') {
            element = document.getElementById(selector);
        } else if (selector.nodeType === 1) {
            element = selector;
        } else {
            throw new Error('Invalid selector');
        }

        if (element === null || element === undefined) {
            throw  new Error('Element is undefined / null');
        }

        element = document.getElementById(selector);

        allButtons = element.getElementsByClassName('button');
        buttonsLength = allButtons.length;

        for (i = 0; i < buttonsLength; i += 1) {
            currentButton = allButtons[i];

            currentButton.innerHTML = 'hide';
            currentButton.addEventListener('click', function () {
                var nextContent = this.nextElementSibling,
                    nextButton = this.nextElementSibling;

                while (nextContent.className !== 'content') {
                    nextContent = nextContent.nextElementSibling;
                }

                if (nextContent && nextContent.className === 'content') {
                    while (nextButton.className !== 'button') {
                        nextButton = nextButton.nextElementSibling;
                    }
                }

                if (nextButton.className === 'button') {
                    if (nextContent.style.display === 'none') {
                        nextContent.style.display = '';
                        this.innerHTML = 'hide';
                    } else {
                        nextContent.style.display = 'none';
                        this.innerHTML = 'show';
                    }
                }
            });
        }
    };
}

module.exports = solve;