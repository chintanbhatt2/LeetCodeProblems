using System;

namespace Leetcode
{
    public class Trib
    {
        private static Dictionary<int, int> Memo = new Dictionary<int, int>();

        public int Tribonacci(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            
            if(n < 1)
            {
                return 0;
            }
            if(Memo.ContainsKey(n))
            {
                return Memo[n];
            }
            else
            {
                Memo[n] = Tribonacci(n-3) + Tribonacci(n-2) + Tribonacci(n-1);
                return Memo[n];
            }
        }
    }
}