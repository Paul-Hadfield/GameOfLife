using System;

namespace GameOfLife
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