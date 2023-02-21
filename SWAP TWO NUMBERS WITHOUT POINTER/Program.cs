using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter the first number:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before Swapping the numbers first="+n+" and second number="+m);
        int temp;
      temp=n;
        n = m;
        m = temp;

        Console.WriteLine("After Swapping the numbers first=" + n + " and second number=" + m);
    }
}