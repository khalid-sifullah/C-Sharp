using System;


class FORLOOP
{
    static void Main(string[] args)
    {
        int n;
        Console.Write("Enter the limit: ");
       n =Convert.ToInt32( Console.ReadLine());
        Console.Write("The input :\n");
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine(i);
        }
        int p;
        Console.Write("Enter the value of Array length");
        int m[5];
        p = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of Array length");

        for (int i=0;i<5;i++)
        {

            m[i] = Convert.ToInt32(Console.ReadLine());


        }

        Console.Write(" The value of Array length");

        for (int i = 0; i <m.Length; i++)
        {

            Console.Write(m[i]);


        }

    }
}

















