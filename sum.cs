using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class sum
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter num1:");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2:");
            int b=Convert.ToInt32(Console.ReadLine());
            int sum;
            sum = a + b;
            Console.WriteLine(sum);
        }
     }
}