using System;

namespace Leetcode
{
    public class Program
    {
        public static void Main()
        {
            NI n = new NI();
            char[][] grid = new char[3][];
            grid[0] = new char[]{'1','1','1'};
            grid[1] = new char[]{'0','1','0'};
            grid[2] = new char[]{'1','1','1'};
            System.Console.WriteLine(n.NumIslands(grid));
        }
    }
}