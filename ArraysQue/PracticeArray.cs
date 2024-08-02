using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysQue
{
    public class PracticeArray
    {
        public static void Main(string[] args)
        {
            //AscendingArray.MyAscendingArray();
            //ReverseArray();
            //Console.ReadLine();
            ReverseStringArray();
            Console.ReadLine();
            //    int[] intArray = new int[] { 2, 9, 4, 3, 5, 1, 7 };
            //    foreach (int i in intArray)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    Console.WriteLine( "length of an array is {0}",  intArray.Length);

        }

        public static void ReverseArray()
        {
            int[] IntArray = new int[] {1,2,3,4,4,5,6,7,8,9};
         
            int i = IntArray.Length - 1;
            string newstring = string.Empty;
            while(i >=0 )
            {
                newstring = IntArray[i] + " "+ newstring;
                i--;
            }
            Console.WriteLine(newstring.Trim());
        }

        public static void ReverseStringArray()
        {
            string[] IntArray = new string[] { "ABCD", "EFGH", "IJKL" ,"MNOPQRS", "XYZ"};
            Console.WriteLine("Original Array is : ");
            foreach(var item  in IntArray)
            {
                Console.WriteLine(item + " ");
            }
            int i = 0;
            int j = IntArray.Length - 1;
            while (i<j)
            {
                string temp = IntArray[i];
                IntArray[i] = IntArray[j];
                IntArray[j] = temp;
                i++;
                j--;
            }

            Console.WriteLine("Reversed Array is : ");
            foreach (var item in IntArray)
            {
                Console.WriteLine(item + " ");
            }
            Console.ReadLine();
        }


    }
}
