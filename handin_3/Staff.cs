using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin_3
{
    public class Staff : Person
    {
        private int salary;

        public Staff(int salary, string name, string password) : base(name, password)
        {
            this.salary = salary;
        }

        public int Salary { get { return salary;  } set { salary = value; } }
    }
}