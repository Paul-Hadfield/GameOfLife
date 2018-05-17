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

        private static int GetCountOfLiveNeighbours(bool[,] grid, int xPos, int yPos)
        {
            var minX = xPos - 1;
            var maxX = xPos + 1;
            var minY = yPos - 1;
            var maxY = yPos + 1;

            if (minX < 0)
            {
                minX = 0;
            }

            if (maxX >= grid.GetLength(0))
            {
                maxX = grid.GetLength(0) - 1;
            }

            if (minY < 0)
            {
                minY = 0;
            }

            if (maxY >= grid.GetLength(1))
            {
                maxY = grid.GetLength(1) - 1;
            }

            var liveNeighbours = 0;

            for (var x = minX; x <= maxX; x++)
            {
                for (var y = minY; y <= maxY; y++)
                {
                    if (x == xPos && y == yPos)
                    {
                        continue;
                    }

                    if (grid[x, y])
                    {
                        liveNeighbours++;
                    }
                }
            }

            return liveNeighbours;
        }

        private static void Output(bool[,] grid)
        {

            Console.WriteLine("Next Cycle>>>");
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
