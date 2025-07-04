using System;

public class Class1
{
	public Class1()
	{

    public static void Main(string[] args)
    {
        //point 1 -- for no of rows
        for (int i = 1; i <= 5; i++)
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
