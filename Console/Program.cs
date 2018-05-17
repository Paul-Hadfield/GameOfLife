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
            var grid = new SeederFactory().Create(SeederEnum.Blinker).Seed();
            
            var game = new GameOfLineEngine(
                                new LiveNeighbourCounter(),
                                new RulesEngine(),
                                new TabularConsoleOutput(),
                                new ConsoleLooper());

            game.Process(grid);
        }

    }
}
