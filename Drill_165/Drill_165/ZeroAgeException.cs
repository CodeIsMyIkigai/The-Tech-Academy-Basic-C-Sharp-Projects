using System;
using System.Collections.Generic;
using System.Text;

namespace Drill_165
{
    class ZeroAgeException: Exception
    {

        public ZeroAgeException()
        {
        }
        public ZeroAgeException(string message) : base(message)
        {
        }
        public ZeroAgeException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
