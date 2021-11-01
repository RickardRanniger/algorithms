using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;

namespace Algorithms
{
    public class TravelGrid
    {
        public long calc(int x, int y, Dictionary<(int, int), long> memo)
        {
            if (memo.ContainsKey((x, y))) return memo[(x, y)];
            if (x == 0 || y == 0) return 0;
            if (x == 1 && y == 1) return 1;
            memo[(x, y)] = calc(x - 1, y - 1, memo);// + calc(x, y - 1, memo);
            return memo[(x, y)];
        }
    }
}