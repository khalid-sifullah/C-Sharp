
using System;
class prrogram
{
    static void Main(string[]args)
    {
        Console.Write("Enter the value of n and k:");
        string[] p = Console.ReadLine().Split(' ');
        int n = int.Parse(p[0]);
        int k = int.Parse(p[1]);
        
        for (int i=0;i<k;i++)
        {
            if (n % 10 == 0)
            {
                 n = n / 10;
               
            }
            else
                n = n - 1;
        }
        
        Console.Write(n);
    }
}