/* Task Description */
/*
 *	Create a module for working with books
 *	The module must provide the following functionalities:
 *	Add a new book to category
 *	Each book has unique title, author and ISBN
 *	It must return the newly created book with assigned ID
 *	If the category is missing, it must be automatically created
 *	List all books
 *	Books are sorted by ID
 *	This can be done by author, by category or all
 *	List all categories
 *	Categories are sorted by ID
 *	Each book/category has a unique identifier (ID) that is a number greater than or equal to 1
 *	When adding a book/category, the ID is generated automatically
 *	Add validation everywhere, where possible
 *	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	Author is any non-empty string
 *	Unique params are Book title and Book ISBN
 *	Book ISBN is an unique code that contains either 10 or 13 digits
 *	If something is not valid - throw Error
 */
function solve() {
    var library = (function () {
        var books = [],
            categories = [];

        var i,
            len;

        // Validate all book attributes
        function isValidBook(book) {
            if (book.title.length < 2) {
                throw new Error('Title is too short');
            } else if (book.title.length > 100) {
                throw new Error('Title is too long');
            } else if (book.category.length < 2) {
                throw new Error('Category name is too short');
            } else if (book.category.length > 100) {
                throw new Error('Category name is too long');
            } else if (isNaN(book.isbn)) {
                throw new Error('ISBN should contain only digits');
            } else if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw new Error('ISBN length should be 10 or 13 digits');
            } else if (!book.author) {
                throw new Error('Author field is empty');
            } else {
                return true;
            }
        }

        function isUniqueBook(book) {
            for (i = 0, len = books.length; i < len; i += 1) {
                if (books[i].title === book.title) {
                    throw new Error('Title already added');
                } else if (books[i].isbn === book.isbn) {
                    throw new Error('ISBN already added');
                } else {
                    return true;
                }
            }
        }

        function listBooks() {
            var prop,
                result;

            // Sort by ID
            books = books.sort(function (a, b) {
                return a.id - b.id;
            });

            if (arguments.length === 0) {
                return books;
            }

            for (prop in arguments[0]) {
                result = filterBooks(books, prop, arguments[0][prop]);
            }

            function filterBooks(booksArr, key, value) {
                return booksArr.filter(function (book) {
                    return book[key] === value;
                });
            }

            return result;
        }

        function addBook(book) {
            isValidBook(book);
            isUniqueBook(book);

            book.ID = books.length + 1;
            books.push(book);

            // Duplicate category check
            if (categories.indexOf(book.category) === -1) {
                categories.push(book.category);
            }

            return book;
        }

        function listCategories() {
            return categories;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}

module.exports = solve;