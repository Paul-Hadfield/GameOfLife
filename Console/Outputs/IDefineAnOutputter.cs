namespace GameOfLife.Outputs
{
    public interface IDefineAnOutputter
    {
        void Write(bool[,] grid);
    }
}
