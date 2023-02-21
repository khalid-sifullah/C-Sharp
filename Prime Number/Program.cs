using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter any number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        for(int i=1; i<=n; i++)
        {
            if (n % i == 0)
                count = count + 1;
        }
        switch (count)
        {
            case 2:
                Console.Write("The " + n + " is a prime number.");
                break;
            default:
                Console.Write("The " + n + " is not a prime number.");
                break;
        }
    }
}