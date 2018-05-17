using System;

namespace GameOfLife.Seeders
{
    public class BeaconSeeder : IDefineASeeder
    {
        public bool[,] Seed()
        {
            var grid = new bool[6, 6];
            grid[1, 1] = true;
            grid[2, 1] = true;
            grid[1, 2] = true;
            grid[4, 4] = true;
            grid[3, 4] = true;
            grid[4, 3] = true;
            return grid;
        }
    }
}