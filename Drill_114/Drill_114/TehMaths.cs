using System;
using System.Collections.Generic;
using System.Text;

/* This should be a static class with static methods... requirements asked me to instanciate the class... */

namespace Drill_114
{
    class TehMaths
    {

        public int DoSomeMaths(int input)
        {
            input += 100;
            return input;
        }

        public int DoSomeMaths(decimal input)
        {
            input += 100;
            int output = (int)input;
            return output;
        }

        public int DoSomeMaths(string inputString)
        {
            int input;
            int.TryParse(inputString, out input);
            return input;
        }
                                    

    }
}
