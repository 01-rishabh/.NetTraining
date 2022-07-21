using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsTask
{ 
    class HRManagement
    {
        public void Manage()
        {
            Console.WriteLine("I am managing");
        }
    }

    class Employee : HRManagement
    {
        public void Work()
        {
            base.Manage();
            Console.WriteLine("I am Working");
        }

        public void ShowWork()
        {
            Console.WriteLine("My Project is on C#");
        }
    }
    class Department : HRManagement
    {
        public void Location()
        {
            Console.WriteLine("Enter the location for the employee :");
            Console.ReadLine();
        }

        public void SetWork()
        {
            Console.WriteLine("Enter the work assign to the employee :");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        
            HRManagement objHR = new HRManagement();
            objHR.Manage();
            Employee emp = new Employee();
            emp.Work();
            emp.ShowWork();
            Department dept = new Department();
            dept.Location();
            dept.SetWork();
            Console.ReadLine();
        }
    }
}
