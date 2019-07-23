function palindrome(str) {
  let myReg = /[a-z0-9]/ig;
  let myArr =  str.toLowerCase().match(myReg);
  console.log(myArr)

  for (let i = 0; i < myArr.length/2; i++) {
    if (myArr[i] != myArr[myArr.length - 1 - i]) {
      return false;
    }
  }
  return true;
}
console.log(palindrome("0_0 (: /-\ :) 0-0"));
