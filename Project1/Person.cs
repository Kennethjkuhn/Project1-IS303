using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Person
    {

        protected string firstName;
        protected string lastName;

        public Person(string sFirstName, string sLastName)
        {
            this.firstName = sFirstName;
            this.lastName = sLastName;
        }

        public void setFirstName(string currFirst)
        {
            firstName = currFirst;
        }

        public void setLastName(string currLast)
        {
            lastName = currLast;
        }

    }
}
