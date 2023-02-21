using System;
class program
{
    static void Main(string[]args)
    {
        int n, m,i,j;
        int[,] a = new int[10,10];
        int[,] b = new int[10, 10];
        int[,] c = new int[10,10];
        Console.WriteLine("Multiplication of matrix.\n ............................................................................................");
        Console.Write("Enter the number of row:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of culumn:");
        m = int.Parse(Console.ReadLine());

        if (n != m)
        {
            Console.WriteLine("The matrix multiplicatin is not possible. please enter others value of n and m");
        }

        else
        {

            Console.Write("Enter the elements of first matrix:\n");

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= m; j++)
                {
                    Console.Write("Enter the value of a[" + i + "," + j + "]:");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter the elements of second matrix:\n");

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= m; j++)
                {
                    Console.Write("Enter the value of b[" + i + "," + j + "]:");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Now show the two matrix.\n ......................................................................................................");
            Console.WriteLine("The First matrix:");

            for (i = 1; i <= n; i++)
            {
                Console.Write("\n");
                for (j = 1; j <= m; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
            }

            Console.WriteLine("\n The Second matrix:");


            for (i = 1; i <= n; i++)
            {
                Console.Write("\n");
                for (j = 1; j <= m; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
            }




            for (i = 1; i <= n; i++)
            {

                for (j = 1; j <= m; j++)
                {
                    c[i, j] = a[i, j] * b[i, j];
                }
            }

            Console.WriteLine("\nThe product of two matrixs is:");
            for (i = 1; i <= n; i++)
            {
                Console.Write("\n");
                for (j = 1; j <= m; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
            }

        }

    }
}