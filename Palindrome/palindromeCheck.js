function palindrome(str) {
  // regex to find any letter or number
  let myReg = /[a-z0-9]/ig;
  // using match() to store all found elements into a array
  // new array can now be checked for palindrome
  let myArr =  str.toLowerCase().match(myReg);

  // check first index and last index for equality
  // work towards the middle of the array
  for (let i = 0; i < myArr.length/2; i++) {
    if (myArr[i] != myArr[myArr.length - 1 - i]) {
      return false;
    }
  }
  return true;
}
