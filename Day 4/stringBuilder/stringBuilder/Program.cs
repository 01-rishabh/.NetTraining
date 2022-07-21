using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_StringSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //p.Length_String();
            //p.Concat_Method();
            //p.Split_String();
            //p.Compare_String(); 
            p.String_Copy();
            //p.String_Remove();
            //p.String_To_Upper();
            //p.Substring_String();
            //p.Last_index();
            //p.String_Index();
            
            Console.ReadKey();


        }
        #region Length_String
        private void Length_String()
        {
            string str = "String length";
            Console.WriteLine("string: " + str);


            int length = str.Length;
            Console.WriteLine("Length of string is " + length);


        }
        #endregion
        #region ConcatMethod
        private void Concat_Method()
        {

            string str1 = "I am adding";
            Console.WriteLine("string str1: " + str1);


            string str2 = " two strings together";
            Console.WriteLine("string str2: " + str2);


            string joinedString = string.Concat(str1, str2);
            Console.WriteLine("Joined string: " + joinedString);
        }
        
        #endregion
        #region Split_String()
        private void Split_String()
        {
            string s1 = "Hello Rishabh Dora";
            string[] s2 = s1.Split(' ');
            foreach (string s3 in s2)
            {
                Console.WriteLine(s3);
            }
        }

        #endregion
        #region Comapre_StringUsingCompare
        private void Compare_String()
        {
            string s1 = "Global";
            string s2 = "Global";
            string s3 = "Logic";
            string s4 = "check";

            Console.WriteLine(string.Compare(s1, s2));
            Console.WriteLine(string.Compare(s2, s3));
            Console.WriteLine(string.Compare(s3, s4));

        }
        #endregion
        #region Copu_Method
        private void String_Copy()
        {
            string s1 = "You can copy this string.";
            string s2 = string.Copy(s1);
            Console.WriteLine("string original:" + s1);

            Console.WriteLine("string copied:" + s2);
        }
        #endregion
        #region String_Remove_Method
        private void String_Remove()
        {
            string s1 = "Rishabh Dora";
            Console.WriteLine("Original String:" + s1);
            string s2 = s1.Remove(4, 9);
            Console.WriteLine("modified" + s2);

        }
        
        #endregion
        #region String_To_Upper_Case
        private void String_To_Upper()
        {
            string s1 = "Hey! there I am learning DotNet Framework.";
            Console.WriteLine("Original String:" + s1);
            string s2 = s1.ToUpper();
            Console.WriteLine("changed string : " + s2);


        }
        #endregion
        #region String_Substring
        private void Substring_String()
        {
            string s1 = "I got my new laptop send by GLobalLogic.";
            Console.WriteLine("The Original string is:" + s1);
            string s2 = s1.Substring(9);
            Console.WriteLine("substring is :" + s2);
        }

        #endregion
        #region Last_Index
        private void Last_index()
        {
            string s1 = "Print the last index of this string.";
            int index = s1.LastIndexOf('S');
            Console.WriteLine(index);
        }
        #endregion
        #region String_IndexOf
        private void String_Index()
        {
            string s1 = "Print the index of the character in the string asked.";
            int index = s1.IndexOf('C');
            Console.WriteLine(index);
        }
        

        
       
        #endregion



    }

}