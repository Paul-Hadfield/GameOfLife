using System;

namespace GameOfLife.Seeders
{
    public class RandomSeeder : IDefineASeeder
    {
        private readonly Random rnd = new Random();

        public bool[,] Seed()
        {
            var length = 20;
            var grid = new bool[length, length];
            for (var x = 0; x < length; x++)
            {
                for (var y = 0; y < length; y++)
                {
                    if (Populate())
                    {
                        grid[x, y] = true;
                    }
                }
            }

            return grid;
        }

        private bool Populate()
        {
            return this.rnd.Next(100) <= 33;
        }
    }
}
