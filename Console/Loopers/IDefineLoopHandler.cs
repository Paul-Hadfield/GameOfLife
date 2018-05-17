namespace GameOfLife.Loopers
{
    public interface IDefineLoopHandler
    {
        bool ContinueLooping();
        void Pause();
    }
}