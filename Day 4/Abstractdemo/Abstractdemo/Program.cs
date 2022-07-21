using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractdemo
{
    public abstract class MyClass
    {
        public void aa()
        {
            Console.WriteLine("This is not abstract method");
        }
        public abstract void calculate(double x);
    }

    class Sub1 : MyClass
    {
        public override void calculate(double x)
        {
            base.aa();
            Console.WriteLine("Square Root Is " + Math.Sqrt(x));
        }
    }

    public class Sub2 : MyClass
    {
        public override void calculate(double x)
        {
            base.aa();
            Console.WriteLine("Sqaure is :" + (x * x));
        }
    }

    public class Sub3 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("cube is :" + (x * x * x));
        }
       }

    public class Sub4 : MyClass
    {
        public override void calculate(double x)
        {
            Console.WriteLine("Mult is :" + (x * x * x * x));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Sub1 obj1 = new Sub1();
            Sub2 obj2 = new Sub2();
            Sub3 obj3 = new Sub3();
            Sub4 obj4 = new Sub4();
            obj1.calculate(9);
            obj2.calculate(9);
            //obj2.sum(12,78);
            obj3.calculate(9);
            Console.ReadKey();

        }
    }
}
