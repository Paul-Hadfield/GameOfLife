using System;

namespace GameOfLife.Outputs
{
    public interface IDefineAnOutputter
    {
        void Write(bool[,] grid);
    }

    public class StreamingConsoleOutput : IDefineAnOutputter
    {
        public void Write(bool[,] grid)
        {
            Console.WriteLine("Next Cycle>>>");
            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    Console.WriteLine(grid[x, y]);
                }
                Console.WriteLine();
            }
        }
    }
}
