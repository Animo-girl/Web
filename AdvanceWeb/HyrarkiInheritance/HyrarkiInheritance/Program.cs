using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HyrarkiInheritance
{
    class Employee
    {
        public void Displayname( string name)
        {
            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            Parttime p = new Parttime();
            p.Displayname("AAstha");
            p.Salary(5000);
            FullTime f = new FullTime();
            f.Displayname("Parmar");
            f.Salary(20000);
            Console.ReadKey();

        }
    }

    class Parttime:Employee
    {
       public void Salary(int salary)
        {
            salary = salary * 2;
            Console.WriteLine(salary);

        }
    }

    class FullTime:Employee
    {
        public void Salary(int salary)
        {
            salary = salary * 2;
            Console.WriteLine(salary);
        }
    }
}
