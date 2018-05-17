using System;

namespace GameOfLife.Loopers
{
    public class ConsoleLooper : IDefineLoopHandler
    {
        public bool ContinueLooping()
        {
            return true;
        }

        public void Pause()
        {
            Console.ReadKey();

        }
    }
}