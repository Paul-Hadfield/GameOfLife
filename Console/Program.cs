using System.Diagnostics;
using System;
using System.Collections.Generic;
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

            while (true)
            {
                output.Write(grid);
                grid = Process(grid);
                Console.ReadKey();
            }
        }

        private static bool[,] Process(bool[,] grid)
        {
            var newGrid = new bool[grid.GetLength(0),grid.GetLength(1)];

            for (var x = 0; x < grid.GetLength(0); x++)
            {
                for (var y = 0; y < grid.GetLength(1); y++)
                {
                    var liveNeighbours = GetCountOfLiveNeighbours(grid, x,y);
                    newGrid[x, y] = UpdateState(grid[x, y], liveNeighbours);
                }
            }

            return newGrid;
        }

        private static bool UpdateState(bool alive, int liveNeighbours)
        {
            if (new Rule4().IsMatched(alive, liveNeighbours))
            {
                Debug.Print($"Alive: {alive} - Live Neighbours: {liveNeighbours} - Rule Four Passed");
                return true;
            }

            if (new Rule1().IsMatched(alive, liveNeighbours))
            {
                Debug.Print($"Alive: {alive} - Live Neighbours: {liveNeighbours} - Rule One Passed");
                return false;
            }

            if (new Rule2().IsMatched(alive, liveNeighbours))
            {
                Debug.Print($"Alive: {alive} - Live Neighbours: {liveNeighbours} - Rule Two Passed");
                return true;
            }

            if (new Rule3().IsMatched(alive, liveNeighbours))
            {
                Debug.Print($"Alive: {alive} - Live Neighbours: {liveNeighbours} - Rule Three Passed");
                return true;
            }

            Debug.Print($"Alive: {alive} - Live Neighbours: {liveNeighbours} - No rules passed");
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

            Debug.Print($"X: {xPos}, Y: {yPos} - Live Neighbours: {liveNeighbours}");

            return liveNeighbours;
        }
    }
}
