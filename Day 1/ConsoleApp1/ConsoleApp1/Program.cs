using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ///* FActorial */

            // int i, fac = 1;
            // Console.WriteLine("Enter the number");
            // for (i = 1; i <= 5; i++)
            // {
            //     fac = fac * i;
            // }
            // Console.WriteLine(fac);

            ///*
            //int a = 0, b = 1, c, i;
            //Console.Write(a+" "+b+" ");
            //for (i = 2; i <= 7; ++i)
            //{
            //    c = a + b;
            //    Console.Write(c + " ");
            //    a = b;
            //    b = c;

            //}
            //*/

            char x = 'A';
            int i = 0;
            Console.WriteLine(true ? x : 0);
            Console.WriteLine(false ? i : x);

        }
    }
}
