using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class class4

    {
        public static void Main(string[] args)
        {
            //point 1 -- for no of rows
            for (int i = 5; i >= 1; i--)
            {
                //point 2 -- for no of columns
                for (int j = 1; j <= i; j++)
                {
                    //point 3 -- dealing with printing
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
