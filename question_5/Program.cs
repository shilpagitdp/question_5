using System.Collections.Generic;
using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return Name + " - " + Age;
    }
}
class Program
{
    static void Main(string[] args)
    {

        Queue<Person> persons = new Queue<Person>();


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter name of employee " + (i + 1) + " :");
            string name = Console.ReadLine();
            Console.WriteLine("Enter age of employee " + (i + 1) + " :");
            int age = int.Parse(Console.ReadLine());
            persons.Enqueue(new Person()
            {
                Name = name,
                Age = age
            });
        }
        Console.WriteLine("\nPrinting all employee details:");
        Console.WriteLine("Name - Age");
        foreach (Person p in persons)
        {
            Console.WriteLine(p.ToString());
        }
    }
}