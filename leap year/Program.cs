using System;
class program
{
static void Main(string[]args)
    {
        Console.Write("Enter a year:");
        int n = Convert.ToInt32(Console.ReadLine());

        function(n);

    }
    static void function(int n)
    {
        if (n % 400 == 0)
            Console.WriteLine("The year " + n + " is a leap year.");
        else if (n % 100 == 0)
            Console.WriteLine("The year " + n + " is not a leap year.");
        else if (n % 4 == 0)
            Console.WriteLine("The year " + n + " is a leap year.");
        else
            Console.WriteLine("The year " + n + " is not a leap year.");
    }
}
