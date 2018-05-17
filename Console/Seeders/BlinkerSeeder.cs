namespace GameOfLife.Seeders
{
    public class BlinkerSeeder : IDefineASeeder
    {
        public bool[,] Seed()
        {
            var grid = new bool[5, 5];
            grid[1, 2] = true;
            grid[2, 2] = true;
            grid[3, 2] = true;
            return grid;
        }
    }
}