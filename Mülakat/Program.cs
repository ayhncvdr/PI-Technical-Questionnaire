using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap10Part5
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1,num2;
            Console.Write("Please give a number as 1st variable: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please give a number as 2nd variable: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Swap(ref num1, ref num2);
            Console.WriteLine("The value of the 1st variable: " + num1);
            Console.WriteLine("The value of the 2nd variable: " + num2);
            Console.ReadKey();

        }

      
        static void Swap(ref int number1, ref int number2) // pass-by-reference
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }
    }
}
