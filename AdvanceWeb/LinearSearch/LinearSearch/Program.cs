using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,find;
            Console.Write("Enter size :");
            a = int.Parse(Console.ReadLine());

            int []size = new int[a];

            for(int i=0;i<a;i++){
                Console.Write("Enter Item no."+i+" : ");
                size[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter the number that you want to Find :");
            find = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                if (find == size[i])
                {
                    Console.Write("Found");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
