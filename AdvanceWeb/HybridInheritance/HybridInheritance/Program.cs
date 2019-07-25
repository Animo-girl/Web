using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HybridInheritance
{
    class Department {
        protected string dep;
        protected int dep_id;
        protected void dep_get(){
            Console.Write("Enter Department name : ");
            dep = Console.ReadLine();
            Console.Write("Enter Depatment ID : ");
            dep_id = int.Parse(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
