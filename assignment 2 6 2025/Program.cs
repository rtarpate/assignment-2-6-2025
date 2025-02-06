using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_2_6_2025
{
    internal class Program
    {
        //create a method to check if a number is even
        //use this method to check and print out all even number in an array with 10 element form 1 to 10

        


        static bool IsEven(int aNumber)
        {
            bool retValue = false;

            if (aNumber % 2 == 0)
            {
                retValue = true;
            }

            return  retValue;
        }

        static int[] CreateArray()
        {
            int[] retValue = new int[10];

            Random ran = new Random();

            for (int i = 0; i < retValue.Length; i++)
            {
                retValue[i] = ran.Next(1, 11);
            }

            
            return  retValue;
        }

        static void Main(string[] args)
        {
            int[] numbers = CreateArray();

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();



        }
    }
}
