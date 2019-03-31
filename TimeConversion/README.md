### Objective
Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.

Note: Midnight is 12:00:00AM on a 12-hour clock, and 00:00:00 on a 24-hour clock. Noon is 12:00:00PM on a 12-hour clock, and 12:00:00 on a 24-hour clock.

```Sample Input 07:05:45PM```
```Sample Output 19:05:45```

### Challenges
- Midnight. The original solution I had was just a mess of if-statements, and it was all because of "what do I do if the time is midnight?" 
I eventually figured out that I could put constraints on my code to not allow the hours to actually go over 23.
- Editing the string. Another blunder in my original solution: it had many "return" statements. This looked messy and was hard to follow. I decided to build and edit one Stringbuilder object throughout the function, and return whatever became of it by the end. 

Original problem from [hackerrank](https://www.hackerrank.com/challenges/time-conversion/problem) 

#### My Output
![picture](https://puu.sh/D7NSc/496c52eff6.png)
