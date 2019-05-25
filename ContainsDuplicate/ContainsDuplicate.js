var checkForDupes = function(nums) {
    // There cannot be duplicates if there is one 1 or less values
    if (nums.length < 2) {
        return false;
    }

    // Create a set - only unique values. put the array into it
    var thisSet = new Set(nums);

    // If the set length is smaller than array length, we have lost some values
    // that were repeated in the array
    if (thisSet.size < nums.length) {
        return true;
    } else {
        return false;
    }
}
var testArray = [1,2,3,1];
console.log(checkForDupes(testArray));
