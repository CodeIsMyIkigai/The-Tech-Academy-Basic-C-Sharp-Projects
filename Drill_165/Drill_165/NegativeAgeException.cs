using System;
using System.Collections.Generic;
using System.Text;

namespace Drill_165
{
    class NegativeAgeException: Exception
    {
        public NegativeAgeException()
        {            
        }
        public NegativeAgeException(string message):  base(message)
        {
        }
        public NegativeAgeException(string message, Exception inner): base(message, inner)
        {
        }
    }
}
