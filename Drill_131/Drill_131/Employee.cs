using System;
using System.Collections.Generic;
using System.Text;

namespace Drill_131
{
    class Employee<T> : Person
    {
        public int Id { get; set; }

        public List<T> Things { get; set; }

    }
}
