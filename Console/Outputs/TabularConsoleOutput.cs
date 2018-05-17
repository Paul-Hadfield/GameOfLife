using System;

namespace GameOfLife.Outputs
{
    public class TabularConsoleOutput : IDefineAnOutputter
    {
        public void Write(bool[,] grid)
        {
            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(grid[x, y] ? "X" : " ");
                }
                Console.WriteLine();
            }
        }
    }
}