using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
