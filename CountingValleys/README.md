### Objective
Given a string that represents a hiking path which starts and ends at sea level, determine how many times the hiker has walked through a valley.
- A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
- A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.

### Challenges
I needed to determine how I would keep track of the hiker going below sea level and then returning. When i encounter a 'U' in the string, how do I tell the program that means up?
I use Dictionary<char, int> to give a value to each char, and use addition to determine where the hiker currently is. 

Original problem from [hackerrank.](https://www.hackerrank.com/challenges/counting-valleys/problem?h_l=interview&playlist_slugs%5B%5D=interview-preparation-kit&playlist_slugs%5B%5D=warmup)

#### Output
![picture](https://i.imgur.com/OyiKRnD.png)
