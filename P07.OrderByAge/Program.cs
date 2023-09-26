using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string[] input = Console.ReadLine().Split();

            while (input[0] != "End") 
            {
                bool existing = false;
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].Id == int.Parse(input[1]))
                    {
                        people[i].Name = input[0];
                        people[i].Age = int.Parse(input[2]);
                        existing = true;
                        break;
                    }
                }
                if (!existing)
                {
                Person person = new Person(input[0], int.Parse(input[1]), int.Parse(input[2]));
                    people.Add(person);
                }
                input = Console.ReadLine().Split();
            }
            Sorting(people);
        }
        static void Sorting(List<Person> people)
        {

            foreach (Person person in people.OrderBy(person => person.Age)) 
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
        public class Person
        {
            public Person(string name, int id, int age)
            {
                Name = name;
                Id = id;
                Age = age;
            }
            public string Name { get; set; }
            public int Id { get; set; }
            public int Age { get; set;}
        }
    }
}
