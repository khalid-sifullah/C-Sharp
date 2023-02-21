using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter any number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int fac = 1;
        if (n < 0)
        { 
        Console.Write("Enter any Positive number.");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                fac = fac * i;

            }
            Console.Write("The factorial of " + n + " is:" + fac);
        }
        

    }
}