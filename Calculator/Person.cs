using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Person
    {
        public string FirstName;
        public string LastName;
        public bool isMale;

        public Person(string firstName, string lastName, bool isMale)
        {
            FirstName = firstName;
            LastName = lastName;
            this.isMale = isMale;
        }
        

    }
}
