using System;
namespace Leetcode
{
    class FF
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) 
        {
            int color = image[sr][sc];
            if (color != newColor) dfs(image, sr, sc, color, newColor);
            return image;
            


        }

        public void dfs(int[][] image, int r, int c, int color, int newC)
        {
            if(image[r][c] == color)
            {
                image[r][c] = newC;
                if(r >= 1) dfs(image, r-1, c, color, newC);
                if(r+1 < image.Length) dfs(image, r+1, c, color, newC);
                if(c >= 1) dfs(image, r, c-1, color, newC);
                if(c+1 < image[r].Length) dfs(image, r, c+1, color, newC);
            }
        }
    }

    class FloodFillTest
    {
        public void Test()
        {
            FF ff = new FF();

            int[][] image = new int[2][];
            image[0] = new int[] {0, 0, 0};
            image[1] = new int[] {0, 0, 0};
            int[][] Solution = ff.FloodFill(image, 0, 0, 2);
            System.Console.WriteLine(Solution);



        }
    }
}