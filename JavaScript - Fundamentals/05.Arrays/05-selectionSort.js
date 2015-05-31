// Problem 5. Selection sort
// Sorting an array means to arrange its elements in increasing order. Write a script to sort an array. Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc
// Hint: Use a second array

var sample = [8, 2, 3, 0, 22, 14, 10, 40, 33];

console.log(selectionSort(sample));

function selectionSort(arr) {
    for (var i = 0; i < arr.length - 1; i++) { // Number of passes
        var min = i; //min holds the current minimum number position for each pass; i holds the initial min number

        for (var j = i + 1; j < arr.length; j++) { // j = i + 1 as we need to go through unsorted array only
            if (arr[j] < arr[min]) {
                min = j; // change the current min number position if a smaller num is found
            }
        }

        if (min != i) { // after each pass, if the current min num != initial min num, exchange the position
            var tmp = arr[i];
            arr[i] = arr[min];
            arr[min] = tmp;
        }
    }

    return arr;
}