using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = Blinker();

            while (true)
            {
                Output(grid);
                grid = Process(grid);
                Console.ReadKey();
            }
        }

        private static bool[,] Process(bool[,] grid)
        {
            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    var liveNeighbours = GetCountOfLiveNeighbours(grid, x,y);
                    grid[x, y] = UpdateState(grid[x, y], liveNeighbours);
                }
            }

            return grid;
        }

        private static bool UpdateState(bool alive, int liveNeighbours)
        {
            if (!alive)
            {
                return liveNeighbours == 3;
            }

            if (liveNeighbours < 2)
            {
                return false;
            }

            if (liveNeighbours == 2 || liveNeighbours == 3)
            {
                return true;
            }

            return false;
        }

        private static int GetCountOfLiveNeighbours(bool[,] grid, int i, int i1)
        {
            return 0;
        }

        private static void Output(bool[,] grid)
        {
            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    Console.WriteLine(grid[x,y]);
                }
                Console.WriteLine();
            }
        }

        private static bool[,] Blinker()
        {
            var grid = new bool[5, 5];
            grid[1, 2] = true;
            grid[2, 2] = true;
            grid[3, 2] = true;
            return grid;
        }
    }
}
