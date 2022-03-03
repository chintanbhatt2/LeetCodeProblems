namespace Leetcode
{
    public class NI {
        public int NumIslands(char[][] grid) 
        {
            int islandCount = 0;
            for(int i = 0; i < grid.Length; i++)
            {
                for(int j = 0; j < grid[i].Length; j++)
                {
                    if(grid[i][j] == '1')
                    {
                        islandCount++;
                        dfs(i, j, grid);
                    }
                }
            }
            return islandCount;
        }

        public void dfs(int i, int j, char[][] grid)
        {
            if(grid[i][j] == '1')
            {
                grid[i][j] = '2';
                if(i >= 1) dfs(i-1, j, grid);
                if(j >= 1) dfs(i, j-1, grid);
                if(i < grid.Length-1) dfs(i+1, j, grid);
                if(j < grid[i].Length-1) dfs(i, j+1, grid);
            }
        }
    }
}


