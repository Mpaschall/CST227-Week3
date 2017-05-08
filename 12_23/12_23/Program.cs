using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your word.");
            string entered = Console.ReadLine();
            int len = 1;
            string word = "";
            List<string> arr1 = new List<string>();
            List<string> arr2 = new List<string>();

            for (int i = 0; i < entered.Length; i++)
                {
                word = entered.Substring(i, len);
                arr1.Add(word);
            }
            for (int j = arr1.Count-1; j <= entered.Length && j != -1; j--)
            {
                word = arr1[j];
                arr2.Add(word);
            }
            for (int h = 0; h < entered.Length; h++)
            {
                Console.WriteLine("arr1 = " + arr1[h]);
                Console.WriteLine("arr2 = " + arr2[h]);
            }
            bool isEqual = Enumerable.SequenceEqual(arr1, arr2);
            if (isEqual == true)
            {
                Console.WriteLine("Palindrome");
            }
            else
            { 
                Console.WriteLine("Not Palindrome");
            }


        }
    }
}
