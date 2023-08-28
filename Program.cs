using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace TheUniqueElementsOfTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*It is necessary to find only the unique elements of the array*/

            //int[] myArray = { 111, 10, 4, 10, 111, 64, 77, 4, 42, 5 };
            //int element = 0;
            //int[] array2 = new int[element];
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if(myArray[j] == myArray[i])
            //        {
            //            myArray[i] = 0; myArray[j] = 0;
            //            break;
            //        }

            //    }
            //    if (myArray[i] != 0)
            //    {
            //        element = i-1;
            //        array2[i] = myArray[i];
            //    }
            //}
            //Console.WriteLine("[" + string.Join(", ", array2) + "]");
            //Console.ReadLine();

            int[] myArray = { 111, 10, 4, 10, 111, 64, 77, 4, 42, 5 };
            int[] result = myArray.Distinct().ToArray();
            Console.WriteLine("[" + string.Join(", ", result) + "]");
            Console.ReadLine();
        }
    }
}