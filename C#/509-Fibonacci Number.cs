using System;

namespace Leetcode
{
    public class Fibonacci
    {
        private static Dictionary<int,int> Memo = new Dictionary<int, int>();
        public static int Fib(int n)
        {
            if(n == 1)
            {
                return 1;
            }
            
            if(n == 0)
            {
                return 0;
            }

            if(Memo.ContainsKey(n))
            {
                return Memo[n];
            }
            else
            {
                Memo[n] = Fib(n-1) + Fib(n-2);
                return Memo[n];
            }
        }
    }
}