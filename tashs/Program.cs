using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");
            List<Person> people = new List<Person>();
            Person person1 = new Person("Maria", "Knitting", "That sounds great!");
            Person person2 = new Person("Bob", "Cooking", "I'd like to attend it.");
            Person person3 = new Person("Olivia", "Playing hockey", "Great!");
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            Dictionary<string, string> events = new Dictionary<string, string>()
            {
                {"knitting club", "Knitting" },
                {"cooking bento-cakes", "Cooking" },
                {"hockey match", "Playing hockey" }
            };
            Console.WriteLine("Enter the name of event:");
            string input = Console.ReadLine();
            input.ToLower();
            if( input != null)
            {
                if (events.ContainsKey(input))
                {
                    string value = events[input];
                    if ( value == "Knitting")
                    {
                        person1.Print();
                    }
                    else if ( value == "Cooking")
                    {
                        person2.Print();
                    }
                    else if ( value == "Playing hockey")
                    {
                        person3.Print();
                    }
                }
            }
            else
            {
                Console.WriteLine("Something went wrong. Please, check your input and try again.");
            }

            Console.ReadKey(); 
            

            
        }
    }
}
