using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            int result1 = obj.sum(3, 5);
            int result2 = obj.sub(5, 2);
            int result3 = obj.mul(3, 4);
            Console.WriteLine("Hello Gl,");
            Console.WriteLine("result1 {0}", result1);
            Console.WriteLine("result2 {0}", result2);
            Console.WriteLine("result3 {0}", result3); 
            Console.ReadLine();
        }
    }
}
