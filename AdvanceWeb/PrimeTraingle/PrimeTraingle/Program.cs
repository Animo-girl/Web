using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimeTraingle
{
    class Program
    {
        static int start = 2;
        static void Main(string[] args)
        {
            int a;
            
            Console.Write("Enter the no. of Layers for Prime No. Traingle :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int b = 0; b < a; b++) {
                int counter = 0;
                for (int j = 0; j < a - b; j++)
                {
                    Console.Write("   ");
                }
                for (int j = 0; j < 2 * b - 1; j++)
                {
                    counter++;
                    pr(counter);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void pr(int counter) {
            int i = 2;
            while (counter > 0) {
                if (i == start)
                {
                    Console.Write(start);
                    start++;
                    counter--;
                }
                else
                {
                    int status = 0;
                    for (i = 2; i < start; i++)
                    {
                        if (start % i == 0)
                        {
                            status = 1;
                            break;
                        }
                        else
                        {
                            status = 0;
                        }
                    }
                    if (status == 0)
                    {
                        Console.Write(start+" ");
                        start++;
                        counter--;
                        break;
                    }
                    else
                    {
                        start++;
                    }
                }               
            }
        }
    }
}

