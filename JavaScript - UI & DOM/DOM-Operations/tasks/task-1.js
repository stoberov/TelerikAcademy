/* globals $ */

/* 

 Create a function that takes an id or DOM element and an array of contents

 * if an id is provided, select the element
 * Add divs to the element
 * Each div's content must be one of the items from the contents array
 * The function must remove all previous content from the DOM element provided
 * Throws if:
 * The provided first parameter is neither string or existing DOM element
 * The provided id does not select anything (there is no element that has such an id)
 * Any of the function params is missing
 * Any of the function params is not as described
 * Any of the contents is neight `string` or `number`
 * In that case, the content of the element **must not be** changed
 */

module.exports = function () {

    return function (element, contents) {
        // Validate function parameters
        validateElement(element);
        validateContents(contents);

        element = getValidElement(element);
        appendContentsToElement(element, contents);

        function validateElement(element) {
            if (element === undefined || element === null) {
                throw new Error('Element is undefined / null.');
            }
        }

        function validateContents(contents) {
            if (contents === undefined || contents === null) {
                throw new Error('Contents is undefined / null.');
            }

            var i,
                len = contents.length;

            for (i = 0; i < len; i += 1) {
                validateContent(contents[i]);
            }
        }

        function validateContent(content) {
            if (typeof content !== "string" && typeof content !== "number") {
                throw new Error('Invalid format.');
            }
        }

        function getValidElement(element) {
            if (typeof element === 'string') {
                element = document.getElementById(element);
            }

            if (!(element instanceof HTMLElement)) {
                throw new Error('Invalid HTML element.');
            }

            return element;
        }

        function appendContentsToElement(element, contents) {
            var div,
                frag,
                i,
                len,
                newDiv;

            element.innerHTML = '';
            div = document.createElement('div');
            frag = document.createDocumentFragment();

            for (i = 0, len = contents.length; i < len; i += 1) {
                newDiv = div.cloneNode(true);
                newDiv.innerHTML = contents[i];
                frag.appendChild(newDiv);
            }

            element.appendChild(frag);
        }
    };
};