using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter last number:");
        int b = Convert.ToInt32(Console.ReadLine());
        sum(a, b);
    }
    static void sum(int x,int y)
    {
        int s=0;
        int o = 0;
        for(int i=x;i<=y;i++)
        {
            s = i + 1;

        }
        Console.WriteLine("The Sum between " + x + " and " + y + " is :" + s);
        for (int i = 1; i <= y; i++)
        {
             o= i + 2;

        }
        Console.WriteLine("The Sum of odd number up to " + y + " is :" + o);
    }
}