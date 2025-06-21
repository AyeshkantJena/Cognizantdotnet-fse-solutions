Logic for Exercise 7
-----------------------

Step 1: Understanding Recursion
Recursion is a function calling itself to solve smaller subproblems.

Used here to calculate compound interest recursively.

Formula used:
FV(n) = FV(n-1) * (1 + r)
Base case: FV(0) = principal

Step 2: Setup
The method CalculateFutureValue takes 3 parameters: principal, rate, and years.

If years is 0, the method returns the initial principal.

Step 3: Recursive Execution (Basic Version)
Call Chain (for 5 years):

CalculateFutureValue(1000, 0.10, 5)
→ CalculateFutureValue(..., 4)
→ ...
→ CalculateFutureValue(..., 0) => returns 1000
Each level multiplies the result from the previous year by (1 + rate).

So:

Year 0: 1000  
Year 1: 1000 * 1.10 = 1100  
Year 2: 1100 * 1.10 = 1210  
Year 3: 1210 * 1.10 = 1331  
Year 4: 1331 * 1.10 = 1464.10  
Year 5: 1464.10 * 1.10 = 1610.51
Step 4: Memoized Execution (Optimized)
An array memo[] is used to store previously calculated values.

Before computing FV(n), it checks if memo[n] exists.

This avoids recomputation and reduces overhead.

Time Complexity Analysis
1. Without Memoization:
Time: O(n)

Each call computes one level, but it's efficient due to no overlapping subproblems.

2. With Memoization:
Time: O(n)

Space: O(n) (for memo array and call stack)

Memoization shines when recursive calls overlap — it caches results for reuse.


----------------------------------------------------------------------------------------