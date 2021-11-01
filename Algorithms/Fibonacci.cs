using System.Collections.Generic;

namespace Algorithms
{
    public static class Fibonacci
    {
        public static long Fib(int n, Dictionary<int,long> memo)
        {
            if (n <= 2) return 1;
            if(!memo.ContainsKey(n)) memo[n] = Fib(n - 1, memo) + Fib(n - 2, memo);
            return memo[n];
        }
    }
}