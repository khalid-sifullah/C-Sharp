using System;
class program
{
    static void Main(string[]args)
    {
        int i, j, r, k;
        int[,] a = new int[10, 10];
        int[,] b = new int[10, 10];
        int[,] c = new int[10, 10];
        Console.WriteLine("Addition of Two Matrix!!!!\n..................................................................................................................");

        Console.Write("Enter the number of row:");
        r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of culumn:");
        k = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the elements of first matrix:\n");
        for(i=1; i<=r;i++)
        {
            for (j = 1; j <= k; j++)
            {
                 
                Console.WriteLine("Enter the value of a[" + i + "," + j + "]:");
                a[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("................................................................................................................\nEnter the elements of second matrix:");
        for (i = 1; i <= r; i++)
        {
            for (j = 1; j <= k; j++)
            {

                Console.WriteLine("Enter the value of b[" + i + "," + j + "]:");
                b[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("................................................................................................................\n Now show the two matrix:");
        for (i = 1; i <=r; i++)
        {
            Console.Write("\n");
            for (j = 1; j <= k; j++)
            {
                Console.Write(a[i, j]+" ");
            }
        }
        Console.WriteLine("\n................................................................................................................");
        for (i = 1; i <= r; i++)
        {
            Console.Write("\n");
            for (j = 1; j <= k; j++)
            {
                Console.Write(b[i, j]+" ");
            }
        }
        for (i = 1; i <= r; i++)
        {
            for (j = 1; j <= k; j++)
            {

                c[i, j] = a[i, j] + b[i, j];
            }
        }
        Console.WriteLine("\n................................................................................................................\n The Rusulant matrix:");
        for (i = 1; i <= r; i++)
        {
            Console.Write("\n");
            for (j = 1; j <= k; j++)
            {
                Console.Write(c[i, j]+" ");
            }
        }
    }
}