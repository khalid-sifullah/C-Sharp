using System;
class program
{
    static void Main(string[] args)
    {

        Console.Write(" Enter first number:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write(" \nEnter second number:");
        int m = Convert.ToInt32(Console.ReadLine());
        int x = n;
        int y=m;
            
        while(y!=0)
        {
            int rem = x % y;
            x = y;
            y= rem;
        }
        int gcd = x;
        Console.WriteLine("The GCD:" + gcd);
        int lcm = n * m / gcd;
        Console.WriteLine("The LCM:" + lcm);
    }
}