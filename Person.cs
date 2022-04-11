using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayThree
{
    class Person
    {
        public string name;
        public int age;
        public double weight;
        public double height;

        public Person()
        {
            this.name = "PlaceHolder Name";
        }

        public Person(string name)
        {
            this.name = name;
        }
        public void walk()
        {
            Console.WriteLine($"{name} is walking now!");
        }
    }
}
