// the initial score doesnt count
// i want to keep track of the number of CHANGES to the records

function breakingRecords(scores) {
  let min = scores[0];
  let max = scores[0];
  // count the number of changes for each
  var changeArr = [0,0];

  // starting at index [1] allows me to keep track only of changes, not initial score
  for (let i = 1; i < scores.length; i++) {
      if (scores[i] > max) {
        max = scores[i];
        // max score changed. record it
        changeArr[0]++;
      } else if (scores[i] < min) {
        min = scores[i];
        // min score changed. record it
        changeArr[1]++;
      }
    }
    return changeArr;
  }

// array is the score for each game, in order
// test data
let scoreArray1 = [10, 5, 20, 20, 4, 5, 2, 25, 1];
let scoreArray2 = [3, 4, 21, 36, 10, 28, 35, 5, 24, 42]
console.log(breakingRecords(scoreArray1));
console.log(breakingRecords(scoreArray2));
