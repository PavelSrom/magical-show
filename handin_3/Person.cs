using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace handin_3
{
    public abstract class Person
    {
        private static int numOfInstances = 0;
        private int id;
        private string name;
        private string password;

        public Person(string name, string password)
        {
            this.id = numOfInstances++;
            this.name = name;
            this.password = password;

            numOfInstances++;
        }

        public bool IsAuth (string name, string password)
        {
            return name == this.name && password == this.password;
        }
    }
}