using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class Person
    {
        public string Name { get; set; }
        public string Hobby { get; set; }
        public string Reaction { get; set; }

        public Person(string name, string hobby, string reaction) 
        {
            Name = name;
            Hobby = hobby;
            Reaction = reaction;
        }
        public void Print()
        {
            Console.WriteLine($"{Name} said: {Reaction}");
        }
    }
}
