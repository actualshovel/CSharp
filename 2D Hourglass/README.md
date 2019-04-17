### Objective 
Calculate the sum of each hourglass in a 6x6 2D array. Return the maximum hourglass sum. 

```
Sample 2D array:

1 1 1 0 0 0
0 1 0 0 0 0
1 1 1 0 0 0
0 0 2 4 4 0
0 0 0 2 0 0
0 0 1 2 4 0

Sample of the first 3 hourglasses: 

111   110   100
 1     0     0
111   110   100
```

#### Challenges
- My code had to be rewritten to get exactly what I want. Instead of getting caught up finding where the hourglasses are, I can pick a point and find the indices to the rest of the hourglass based on a common relationship. 
- I was not getting my expected output when the max sum was less than zero. This is because the maxSum variable was initialized as 0. I fixed this by initializing the maxSum to the minumum integer value.

Original problem from [hackerrank.](https://www.hackerrank.com/challenges/2d-array/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=arrays)
