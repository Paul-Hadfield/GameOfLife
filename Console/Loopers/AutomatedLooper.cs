using System.Threading;

namespace GameOfLife.Loopers
{
    public class AutomatedLooper : IDefineLoopHandler
    {
        public bool ContinueLooping()
        {
            return true;
        }

        public void Pause()
        {
            Thread.Sleep(100);
        }
    }
}