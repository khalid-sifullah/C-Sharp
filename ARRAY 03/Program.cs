using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter the number:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] fibo = new int[100];
        fibo[0] = 1;
        fibo[1] = 1;

        for (int i = 0; i <= n; i++)
        {
            if (i <= 1)
            {
                Console.Write(" " + fibo[i]);
            }
            else
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];
                Console.Write(" " + fibo[i]);
            }
        }


        
    }
}