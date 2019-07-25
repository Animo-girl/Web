using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodsParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,a,b,sum,c,d;
            Console.Write("Enter a number");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("\nValue Entered : "+num+"\n\n");

            value(num);
            Console.WriteLine("Original value : "+num+"\n");
            reference(ref num);
            Console.WriteLine("Original value : "+num+"\n");

            Console.Write("Enter 1st number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            b = int.Parse(Console.ReadLine());

            Output_parameter(a,b,out sum);
            Console.WriteLine("Original Values : "+a+" & "+b+"\n");

            Console.Write("Enter 1st number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Enter 3rd number : ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Enter 4th number : ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine(Arguments(a,b,c,d));

            Console.ReadKey();
        }
        static void value(int number) 
        {
            number = number + 10;
            Console.WriteLine("Calculated by Value: " + number);
        }
        static void reference(ref int number)
        {
            number = number + 10;
            Console.WriteLine("Calculated by Reference: " + number);
        }
        static void Output_parameter(int a,int b,out int sum)
        {
            sum = a+b;
            Console.WriteLine("Calculated by Output Parameter: " + sum);
        }
        static int Arguments(params int[]a)
        {
            int sum =0;
            foreach(int i in a){
                sum=sum+i;
            }
            return sum;
            //Console.WriteLine("Calculated by Arguments: " + sum);
        }

    }
}
