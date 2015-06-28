/* Task Description */
/*
 * Create an object domElement, that has the following properties and methods:
 * use prototypal inheritance, without function constructors
 * method init() that gets the domElement type
 * i.e. `Object.create(domElement).init('div')`
 * property type that is the type of the domElement
 * a valid type is any non-empty string that contains only Latin letters and digits
 * property innerHTML of type string
 * gets the domElement, parsed as valid HTML
 * <type attr1="value1" attr2="value2" ...> .. content / children's.innerHTML .. </type>
 * property content of type string
 * sets the content of the element
 * works only if there are no children
 * property attributes
 * each attribute has name and value
 * a valid attribute has a non-empty string for a name that contains only Latin letters and digits or dashes (-)
 * property children
 * each child is a domElement or a string
 * property parent
 * parent is a domElement
 * method appendChild(domElement / string)
 * appends to the end of children list
 * method addAttribute(name, value)
 * throw Error if type is not valid
 * method removeAttribute(attribute)
 * throw Error if attribute does not exist in the domElement
 */

/* Example

 var meta = Object.create(domElement)
 .init('meta')
 .addAttribute('charset', 'utf-8');

 var head = Object.create(domElement)
 .init('head')
 .appendChild(meta)

 var div = Object.create(domElement)
 .init('div')
 .addAttribute('style', 'font-size: 42px');

 div.content = 'Hello, world!';

 var body = Object.create(domElement)
 .init('body')
 .appendChild(div)
 .addAttribute('id', 'cuki')
 .addAttribute('bgcolor', '#012345');

 var root = Object.create(domElement)
 .init('html')
 .appendChild(head)
 .appendChild(body);

 console.log(root.innerHTML);
 Outputs:
 <html><head><meta charset="utf-8"></meta></head><body bgcolor="#012345" id="cuki"><div style="font-size: 42px">Hello, world!</div></body></html>
 */

function solve() {
    'use strict';

    var domElement = (function () {
        function isValidType(type) {
            var allowedCharacters = /^[a-zA-Z0-9]+$/;

            if (!allowedCharacters.test(type) || type === '' || typeof type !== 'string') {
                throw new Error('Type must be a non-empty string and contain only Latin letters and digits');
            }
        }

        function isValidAttribute(attribute) {
            var allowedCharacters = /^[a-zA-Z0-9\-]+$/;

            if (!allowedCharacters.test(attribute)) {
                throw new Error('Attribute name must be a non-empty string and contain only Latin letters and digits (including dash)');
            }
        }

        function sortAttributes(attributes) {
            var sorted = attributes.slice();

            sorted.sort(function (a, b) {
                return a.name > b.name;
            });

            return sorted;
        }

        var domElement = {
            init: function (type) {
                this.type = type;
                this.content = '';
                this.attributes = [];
                this.children = [];
                this.parent = '';

                return this;
            },
            appendChild: function (child) {
                this.children.push(child);

                if (typeof child === 'object') {
                    child.parent = this;
                }

                return this;
            },
            addAttribute: function (name, value) {
                var attribute = {},
                    currentAttribute,
                    isSameName = false,
                    i;

                isValidAttribute(name);

                attribute.name = name;
                attribute.value = value;

                for (i = 0; i < this.attributes.length; i += 1) {
                    currentAttribute = this.attributes[i];
                    if (name === currentAttribute.name) {
                        currentAttribute.value = value;
                        isSameName = true;
                    }
                }

                if (!isSameName) {
                    this.attributes.push(attribute);
                }

                return this;
            },
            removeAttribute: function (attributeName) {
                var index,
                    i;

                for (i = 0; i < this.attributes.length; i += 1) {
                    if (this.attributes[i].name === attributeName) {
                        index = i;
                        break;
                    }
                }

                if (index !== undefined) {
                    this.attributes.splice(index, 1);
                } else {
                    throw new Error('Attribute does not exist');
                }

                return this;
            }
        };

        Object.defineProperties(domElement, {
            type: {
                get: function () {
                    return this._type;
                },
                set: function (value) {
                    isValidType(value);
                    this._type = value;
                }
            },
            content: {
                get: function () {
                    if (this.children.length) {
                        return '';
                    }

                    return this._content;
                },
                set: function (value) {
                    this._content = value;
                }
            },
            attributes: {
                get: function () {
                    return this._attributes;
                },
                set: function (value) {
                    this._attributes = value;
                }
            },
            parent: {
                get: function () {
                    return this._parent;
                },
                set: function (value) {
                    this._parent = value;
                }
            },
            children: {
                get: function () {
                    return this._children;
                },
                set: function (value) {
                    this._children = value;
                }
            },
            innerHTML: {
                get: function () {
                    var result = '',
                        child,
                        sortedAttributes,
                        i,
                        j,
                        element;

                    result += '<' + this.type;

                    if (this.attributes.length) {
                        sortedAttributes = sortAttributes(this.attributes);

                        for (i = 0; i < sortedAttributes.length; i += 1) {
                            element = sortedAttributes[i];
                            result += ' ' + element.name + '="' + element.value + '"';
                        }
                    }

                    result += '>';

                    if (this.children.length) {
                        for (j = 0; j < this.children.length; j += 1) {
                            child = this.children[j];
                            if (typeof child === 'string') {
                                result += child;
                            } else {
                                result += child.innerHTML;
                            }

                        }
                    } else {
                        result += this.content;
                    }

                    result += '</' + this.type + '>';

                    return result;
                }
            }
        });

        return domElement;
    }());

    return domElement;
}

module.exports = solve;