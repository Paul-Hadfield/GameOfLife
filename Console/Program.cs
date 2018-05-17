using System.Diagnostics;
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
            
            var game = new GameOfLineEngine(
                                new LiveNeighbourCounter(),
                                new RulesEngine(),
                                new StreamingConsoleOutput());

            game.Process(grid);
        }

    }
}
