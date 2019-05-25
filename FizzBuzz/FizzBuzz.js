/* Implement FizzBuzz from numbers 1 to n
 * Multiples of 3 output "Fizz"
 * Multiples of 5 output "Buzz"
 * Multiples of 3 and 5 outpur "FizzBuzz"
 * Neither will simply output the numbers

 * Result will be an array of strings
*/

var fizzBuzz = function(n) {
    // create array, then count to n
    var result = [];
    for (var i = 1; i <= n; i++) {
        if(i % 15 == 0) {
            result.push("FizzBuzz");
        }else if (i % 3 == 0) {
            result.push("Fizz");
        }else if (i % 5 == 0) {
            result.push("Buzz");
        } else {
            result.push(i);
        }
    };
    // Using .map here ended up being faster than calling toString() on i during the loop - by 8ms
    return result.map(String);
}
var n = 15;
console.log(fizzBuzz(n));
