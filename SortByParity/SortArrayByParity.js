var sortArrayByParity = function(A) {
    var result = [];

    // Put all even numbers into my new array, and remove them from the original
    for (let i = 0; i < A.length; i++) {
        if (A[i] % 2 == 0) {
            result.push(A[i])
            A.splice(i, 1);
            i--;
        }
    }
    // Add the suriving numbers from original array to the end of the new array
    // push() adds to the end of result, and apply() will add the individual members from A[]
    result.push.apply(result, A);
    return result;
};

var input = [3,1,2,4];
console.log(sortArrayByParity(input));
