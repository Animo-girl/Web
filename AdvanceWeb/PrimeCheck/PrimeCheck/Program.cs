using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int input, status=0;
            Console.Write("Enter a number to check if Prime or Not :");
            input = int.Parse(Console.ReadLine());
            for (int i = 2; i <input; i++) {
                if (input % i == 0)
                {
                    status = 1;
                    break;
                }
                else {
                    status = 0;
                }
            }
            if (status == 0)
            {
                Console.WriteLine("No. is Prime No.");
            }
            else {
                Console.WriteLine("No. is Not Prime No.");
            }
            Console.ReadKey();
        }
    }
}
