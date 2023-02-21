using System;
class program
{
    static void Main(string[] args)
    {
        int i, j ,m=0;
        int[,] a = new int[10, 10];
        Console.WriteLine("Enter the elements of first matrix:");
        for (i = 1; i <= 5; i++)
        {
            
            for (j = 1; j <= 5; j++)
            {
                Console.Write("Enter the value of a[" + i + "," + j + "]:");
                a[i, j] = int.Parse(Console.ReadLine());
                
            }
            Console.Write("\n");
        }

        for (i = 1; i <= 5; i++)
        {
            for (j = 1; j <= 5; j++)
            {
                if (a[i, j] == 1)
                {
                   m= Math.Abs(i - 3) + Math.Abs(j - 3);
                    
                }
            }
           
        }
        Console.Write(m);
    }
}
