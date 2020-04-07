using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Demos\Test.txt";

            //List<string> lines = File.ReadAllLines(filePath).ToList();

            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //Console.ReadLine();

            List<Person> people = new List<Person>();

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                string[] entries = line.Split(',');

                Person newPerson = new Person();

                newPerson.FirstName = entries[0];
                newPerson.LastName = entries[1];
                newPerson.Url = entries[2];


                people.Add(newPerson);
            }

            foreach (var Person in people)
            { 
                Console.WriteLine($"{Person.FirstName}{Person.LastName}: {Person.Url} ");
            }

            people.Add(new Person { FirstName = "Greg", LastName = "Jones", Url = "www.test.no" });

            List<string> output = new List<string>();

            foreach (var person in people)
            {
                output.Add($"{ person.FirstName },{ person.LastName }, { person.Url}");
            }

            Console.WriteLine("write to text file");

            File.WriteAllLines(filePath, output);
            Console.WriteLine("All entries written");

        }

    }
}
