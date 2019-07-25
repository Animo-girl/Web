using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstructorProgram
{
    class Program
    {
        public Program() { }
        public Program(string name, int age)
        {
            Console.WriteLine("Name  is "+name+" and age is "+age);
        }
        /*static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Age : ");
            age = int.Parse(Console.ReadLine());

            Program p = new Program(name, age);
            Console.ReadKey();
        }*/
    }

    class callProgram
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            Console.Write("Enter Name : ");
            name = Console.ReadLine();
            Console.Write("Enter Age : ");
            age = int.Parse(Console.ReadLine());

            Program p = new Program(name, age);
            Console.ReadKey();
        }
    }
}
