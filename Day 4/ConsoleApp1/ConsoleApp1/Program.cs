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

            //reverse Array
            //int[] arr = new int[10];
            //for(int i = 10; i > 0; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();


            //Copy elements from one array to another
            //int[] arr1 = {1,2,3,4 };
            //int[] arr2 = new int[arr1.Length];
            //Array.Copy(arr1, arr2, arr1.Length);
            //for(int i = 0; i < arr1.Length; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            //Console.ReadKey();

            //sum
            //int[] arr = { 1, 2, 3, 4 };
            //int sum_arr = 0;
            //for(int i = 0; i < arr.Length; i++)
            //{
            //    sum_arr += arr[i];
            //}
            //Console.Write(sum_arr);
            //Console.ReadKey();



            //Duplicate count
            int[] arr = { 1,3,4,4,5,6,4};
            int i, j, count = 0;
           
            for (i = 0; i < arr.Length; i++)
            {
                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Duplicate elements found: " + count);
            Console.ReadLine();
        }
    }
}
