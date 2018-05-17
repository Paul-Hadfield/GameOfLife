using System.Diagnostics;
using System;
using GameOfLife.Counters;
using GameOfLife.Outputs;
using GameOfLife.Rules;
using GameOfLife.Seeders;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new BlinkerSeeder().Seed();
            var output = new StreamingConsoleOutput();
            var counter = new LiveNeighbourCounter();
            var rulesEngine = new RulesEngine();

            while (true)
            {
                output.Write(grid);
                grid = Process(counter, rulesEngine, grid);
                Console.ReadKey();
            }
        }

        private static bool[,] Process(IDefineANeigbourCounter counter, RulesEngine rulesEngine, bool[,] grid)
        {
            var newGrid = new bool[grid.GetLength(0),grid.GetLength(1)];

            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    var liveNeighbours = counter.Count(grid, x,y);
                    newGrid[x, y] = rulesEngine.DetermineNewState(grid[x, y], liveNeighbours);
                }
            }

            return newGrid;
        }
    }
}
