// Problem 7. Binary search
// Write a script that finds the index of given element in a sorted array of integers by using the binary search algorithm.

var arr = [18, 10, 2, 4, 1, 100, 19, 99];

console.log('Before: ' + arr);

function orderBy(a, b) {
    return a - b;
}

arr.sort(orderBy);

console.log('Sorted: ' + arr);

var firstMember = 0,
    midMember = 0,
    lastMember = arr.length - 1,
    target = 10, // We will find the index for this element
    index = -1;  // A copy of requested index of target

while (firstMember <= lastMember) {
    midMember = Math.floor((firstMember + lastMember) / 2);


    if (arr[midMember] < target) {
        // change min index to search upper sub-array part
        firstMember = midMember + 1;
    }
    else if (arr[midMember] > target) {
        // change max index to search lower sub-array part
        lastMember = midMember - 1;
    }
    else {
        index = midMember;
        break;
    }
}

if (index >= 0) {
    console.log('The target number ' + target + ' is at index ' + index);
}
else if (index < 0) {
    console.log('No index for number ' + target + ' found');
}
