using System;
using System.Collections.Generic;
using System.Runtime.Versioning;

namespace P04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student student = new Student(input[0], input[1], float.Parse(input[2]));
                list.Add(student);
            }
            SortedMethod(list);
        }
        static void SortedMethod(List<Student> input)
        {
            List<Student> sort = new List<Student>();
            int listCount = input.Count;
            float biggest = 0;
            int indexOfBiggest = 0;

            for (int i = 0; i < listCount; i++)
            {
                biggest = 0;
                indexOfBiggest = 0;
                for (int j = 0; j < input.Count; j++)
                {
                    if (input[j].Grade > biggest)
                    {
                        biggest = input[j].Grade;
                        indexOfBiggest = j;
                    }
                    else
                    {
                        continue;
                    }
                }
                sort.Add(input[indexOfBiggest]);
                input.RemoveAt(indexOfBiggest);
            }
            foreach (Student student in sort)
            {
            Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
        public class Student
        {
            public Student(string firstName, string lastName, float grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public float Grade { get; set; }
        }
    }
}
