namespace GameOfLife.Counters
{
    public interface IDefineANeigbourCounter
    {
        int Count(bool[,] grid, int xPos, int yPos);
    }
}