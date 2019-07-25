using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiLevelInheritance
{
    class A{
        protected string g_name, surname;
        protected int g_age;
        protected void gget(){
            Console.Write("Enter GrandFather's name : ");
            g_name = Console.ReadLine();
            Console.Write("Enter Surname : ");
            surname = Console.ReadLine();
            Console.Write("Enter GrandFather's Age : ");
            g_age = int.Parse(Console.ReadLine());
        }
    }

    class B:A
    {
        protected string f_name;
        protected int f_age;
        protected void fget(){
            gget();
            Console.Write("\nEnter Father's name : ");
            f_name = Console.ReadLine();
            Console.Write("Enter Father's Age : ");
            f_age = int.Parse(Console.ReadLine());
        }
    }
    
    class Program:B
    {
        protected string s_name;
        protected int s_age;
        protected void sget(){
            fget();
            Console.Write("\nEnter Son's name : ");
            s_name = Console.ReadLine();
            Console.Write("Enter Son's Age : ");
            s_age = int.Parse(Console.ReadLine());
            show();
        }
        void show(){
            Console.WriteLine("\n\nDetails are as Follows : ");
            Console.WriteLine("Full Name : "+s_name+" "+f_name+" "+g_name+" "+surname);
            Console.WriteLine("Grandfather's age : "+g_age);
            Console.WriteLine("Father's age : "+f_age);
            Console.WriteLine("Son's age : "+s_age);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.sget();
            Console.ReadKey();
        }
    }
}
