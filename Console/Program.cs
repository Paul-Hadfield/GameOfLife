using GameOfLife.Counters;
using GameOfLife.Loopers;
using GameOfLife.Outputs;
using GameOfLife.Rules;
using GameOfLife.Seeders;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = new SeederFactory().Create(SeederEnum.Random).Seed();
            
            var game = new GameOfLineEngine(
                                new LiveNeighbourCounter(),
                                new RulesEngine(),
                                new TabularConsoleOutput(),
                                new AutomatedLooper());

            game.Process(grid);
        }

    }
}
