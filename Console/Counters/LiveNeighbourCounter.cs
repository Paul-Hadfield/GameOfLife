namespace GameOfLife.Counters
{
    public class LiveNeighbourCounter : IDefineANeigbourCounter
    {
        public int Count(bool[,] grid, int xPos, int yPos)
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

            return liveNeighbours;
        }
    }
}
