using GameOfLife.Counters;
using GameOfLife.Loopers;
using GameOfLife.Outputs;
using GameOfLife.Rules;

namespace GameOfLife
{
    public class GameOfLineEngine
    {
        private readonly IDefineANeigbourCounter counter;
        private readonly IDefineARulesEngine rulesEngine;
        private readonly IDefineAnOutputter output;
        private readonly IDefineLoopHandler loopHandler;

        public GameOfLineEngine(IDefineANeigbourCounter counter, IDefineARulesEngine rulesEngine, IDefineAnOutputter output, IDefineLoopHandler loopHandler)
        {
            this.counter = ReturnParameter.OrThrowIfNull(counter, nameof(counter));
            this.rulesEngine = ReturnParameter.OrThrowIfNull(rulesEngine, nameof(rulesEngine));
            this.output = ReturnParameter.OrThrowIfNull(output, nameof(output));
            this.loopHandler = ReturnParameter.OrThrowIfNull(loopHandler, nameof(loopHandler));
        }

        public void Process(bool[,] grid)
        {
            while (loopHandler.ContinueLooping())
            {
                output.Write(grid);
                grid = Process(this.counter, this.rulesEngine, grid);
                loopHandler.Pause();
            }
        }

        private static bool[,] Process(IDefineANeigbourCounter counter, IDefineARulesEngine rulesEngine, bool[,] grid)
        {
            var newGrid = new bool[grid.GetLength(0), grid.GetLength(1)];

            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    var liveNeighbours = counter.Count(grid, x, y);
                    newGrid[x, y] = rulesEngine.DetermineNewState(grid[x, y], liveNeighbours);
                }
            }

            return newGrid;
        }

    }
}