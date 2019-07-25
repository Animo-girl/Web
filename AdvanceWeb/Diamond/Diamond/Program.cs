using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter no of layers : ");
            a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= a; i++) {
                for (int j = 0; j < a-i; j++) {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            for(int i =a-1 ; i>=1 ; i--){
                for (int j = 0; j < a-i; j++) {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i - 1; j++) {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
