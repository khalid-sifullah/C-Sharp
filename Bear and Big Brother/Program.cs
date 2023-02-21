using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter the age of weight of Limak and Bob:");
        string[] p = Console.ReadLine().Split(' ');
       int a = int.Parse(p[0]);
        int b = int.Parse(p[1]);
        int count = 0;
        for (int i=0;i<10;i++)
        {
            if (a>b)
            {
                Console.WriteLine(count);
                break;
            }
            else 
            {
                a = 3 * a;
                b = 2 * b;
                count = count + 1;
            }
        }
    }
}