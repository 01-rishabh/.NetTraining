using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            int result = obj.sum(3, 5);
            Console.WriteLine("Hello Gl,");
            Console.WriteLine("result {0}", result);
            Console.ReadLine();
        }
    }
}
