using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysQue
{
    public class AscendingArray
    {
        public static void MyAscendingArray() 
        {
            int[] MyArray = new int[] { 2017, 2015, 2000, 2022, 2022, 2021, 2024, 2067, 2067, 2100};
            int temp = 0;
            for (int i = 0; i <= MyArray.Length; i++)
            {
                for(int j = i+1; j < MyArray.Length; j++)
                {
                    if (MyArray[i]> MyArray[j])
                    {
                        temp = MyArray[i];
                        MyArray[i]= MyArray[j];
                        MyArray[j] = temp;
                    }
                }
            }
            Console.WriteLine("Ascending Order is :");
            foreach (int i in MyArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Ascending done");
            DescendingArray.MyDescendingArray();
            Console.WriteLine("Descending done");
            Console.ReadLine();
        }

        
    }
}
