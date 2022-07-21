using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s, rev = "";
            //Console.Write("Enter a string : ");
            //s = Console.ReadLine();
            //if (s != "")
            //{
            //    for (int i = s.Length - 1; i >= 0; i--)
            //    {
            //        rev += s[i].ToString();
            //    }
            //    if (rev == s)
            //    {
            //        Console.WriteLine("Palindrome");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Palindrome");
            //    }
            //}
            //Console.ReadLine();

            int num, val, test, sum = 0;
            num = 345;
            test = num;
            while (num > 0)
            {
                val = num % 10;
                sum += (val*val*val);
                num /= 10;
            }

            if (test == sum)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not Armstrong Number");
            Console.ReadLine();
        }
    }
}
