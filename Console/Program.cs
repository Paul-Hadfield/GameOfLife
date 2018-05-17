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
            return grid;
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
