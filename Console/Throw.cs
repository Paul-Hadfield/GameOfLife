using System;

namespace GameOfLife
{
    public static class Throw
    {
        public static void IfNull<T>(T obj, string name)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(name);
            }
        }
    }
}