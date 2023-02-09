using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number:");
            num1= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            num2 = int.Parse(Console.ReadLine());

            temp = num1;
            num1 = num2;
            num2 = temp;
            //After swapping
            Console.WriteLine("First number:" + num1);
            Console.WriteLine("Second number:" + num2);
            Console.ReadLine();
        }
    }
}
