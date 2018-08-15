using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml_reader
{
    class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Programmist { get; private set; }

        public Employee(string name, int age, bool programmist)
        {
            Name = name;
            Age = age;
            Programmist = programmist;
        }

        public override string ToString()
            => Name;
    }
}