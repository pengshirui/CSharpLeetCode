namespace LeetCode.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands/
    /// </summary>
    public class NumberOfIslands
    {
        public int NumIslands(char[,] grid)
        {
            if (grid == null || grid.Length == 0)
            {
                return 0;
            }

            int num = 0;
            for(var i = 0; i < grid.GetLength(0); i++)
            {
                for(var j = 0; j < grid.GetLength(1); j++)
                {
                    if (grid[i, j] == '1')
                    {
                        num++;
                        Dfs(grid, i, j);
                    }
                }
            }
            return num;
        }

        private void Dfs(char[,] grid, int i, int j)
        {
            grid[i, j] = '0';
            // top
            if (i - 1 >= 0 && grid[i - 1, j] == '1')
            {
                Dfs(grid, i - 1, j);
            }
            // left
            if (j - 1 >= 0 && grid[i, j - 1] == '1')
            {
                Dfs(grid, i, j - 1);
            }
            // right
            if (j + 1 < grid.GetLength(1) && grid[i, j + 1] == '1')
            {
                Dfs(grid, i, j + 1);
            }
            // bottom
            if (i + 1 < grid.GetLength(0) && grid[i + 1, j] == '1')
            {
                Dfs(grid, i+ 1, j);
            }
        }
    }
}
