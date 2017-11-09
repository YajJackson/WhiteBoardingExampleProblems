using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSetOne
{
    class Person
    {
        public Person(string first, string last, int age)
        {
            this.FirstName = first;
            this.LastName = last;
            this.Age = age;
        }
        
        public Person(string first, int age)
        {
            this.FirstName = first;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
}
