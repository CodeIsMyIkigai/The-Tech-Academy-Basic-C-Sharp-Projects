using System;
using System.Collections.Generic;
using System.Text;

namespace Drill_126
{
    class Employee: Person, IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("Take this job and shove it.  I ain't working here no more!");        
        }
    }
}
