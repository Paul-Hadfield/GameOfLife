namespace GameOfLife
{
    public interface IDefineLoopHandler
    {
        bool ContinueLooping();
        void Pause();
    }
}