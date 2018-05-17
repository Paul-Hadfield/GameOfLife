using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var grid = Blinker();
        }

        private static bool[,] Blinker()
        {
            var grid = new bool[5, 5];
            return grid;
        }
    }
}
