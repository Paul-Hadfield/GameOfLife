using System;

namespace GameOfLife
{
    public static class ExceptionExtensions
    {
        public static Exception AddData(this Exception exception, string key, object data)
        {
            exception.Data.Add(key, data);
            return exception;
        }
    }
}
