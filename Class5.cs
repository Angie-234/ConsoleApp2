using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class program
    {
        public static void Main(string[] args)
        {
            int row = 5;
            //point 1 -- for no of rows
            for (int i = 1; i <= row; i++)
            {
                //point 2 -- for no of columns
                for (int j = 1; j <= i; j++)
                {
                    //point 3 -- dealing with printing
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
