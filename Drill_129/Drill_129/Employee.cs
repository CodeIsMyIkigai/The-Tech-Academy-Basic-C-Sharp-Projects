using System;
using System.Collections.Generic;
using System.Text;

namespace Drill_129
{
    class Employee : Person
    {
        public int Id { get; set; }

        //Quick Action autogeneration
        public override bool Equals(object obj)
        {
            var employee = obj as Employee;
            return employee != null &&
                   Id == employee.Id;
        }

        //Quick Action autogeneratio
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public static bool operator == (Employee emp1, Employee emp2)
        {
            if(emp1.Id == emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if(emp1.Id != emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
