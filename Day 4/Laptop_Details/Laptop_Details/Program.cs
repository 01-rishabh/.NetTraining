
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laptop_Details
{

    public class Laptop
    {
        public int serial;
        public string name;
        public int model;
        public string processor;
        public string storage;
        public string ram;
        

        public Laptop(string name, int serial, string processor, int model, string storage, string ram)
        {
            this.name = name;
            this.serial = serial;
            this.processor = processor;
            this.model = model;
            this.storage = storage;
            this.ram = ram;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop("Dell", 1, "i7", 2019, "1 Tb", "16 Gb");
            Laptop laptop2 = new Laptop("Hp", 2, "i5", 2018, "2 Tb", "8 GB");
            Laptop laptop3 = new Laptop("Lenovo", 3, "i9", 2020, "1 Tb", "16 GB");
            Laptop laptop4 = new Laptop("Acer", 3, "i9", 2020, "1 Tb", "16 GB");


            Laptop[] listOfLaptops = { laptop1, laptop2, laptop3, laptop4 };
            Console.WriteLine("List of Laptops");
            for(int i = 0; i < listOfLaptops.Length; i++)
            {
                Console.WriteLine(listOfLaptops[i].name);
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("Enter 0 to exit");
                Console.WriteLine("Enter serial number of requested laptop.");


                string serial_entered = Console.ReadLine();
                int serial_int = Convert.ToInt32(serial_entered);

                if(serial_int == 0)
                {
                    break;
                }

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Enter 1 to view model");
                Console.WriteLine("Enter 2 to view Processor");
                Console.WriteLine("Enter 3 to view Storage");
                Console.WriteLine("Enter 4 to view RAM");
           
                string option = Console.ReadLine();
                int opt_int = Convert.ToInt32(option);

                Console.WriteLine("------------------------------------");
                switch (opt_int)
                {
                    case 1:
                        Console.WriteLine(listOfLaptops[serial_int - 1].model);
                        break;
                    case 2:
                        Console.WriteLine(listOfLaptops[serial_int - 1].processor);
                        break;
                    case 3:
                        Console.WriteLine(listOfLaptops[serial_int - 1].storage);
                        break;
                    case 4:
                        Console.WriteLine(listOfLaptops[serial_int - 1].ram);
                        break;

                }
            }
            Console.ReadKey();
        }
    }
}
