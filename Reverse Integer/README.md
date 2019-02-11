### Objective
Given a 32-bit signed integer, reverse digits of an integer.

### Example
```
Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21
```
*Note: Assume we are dealing with an environment which could only store integers within the 32-bit signed integer range: [−231,  231 − 1]. 
For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.*

### What I Learned
- Built significant confidence with strings and the StringBuilder class
- Read up on NumberStyles, giving me tools to consider for future code

### Challenges
- The example *Input: -123 Output -321* threw me off the most. At first, my output would look something like *321-*, and I needed a way
to keep the negative sign in front. To do this I checked for the '-' symbol and moved it appropriately. 
- ~~Doing this without converting to a string is still something I am trying to figure out.~~
- No longer an issue thanks to what I learned from working on a ProjectEuler solution.
