using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter The amount of Numbers:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] m = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter The " +( i+1) + " th number:");
            m[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(" The " + (i +1)+ " th number:" + m[i]);

        }
        int b = m[0] > m[1] && m[0] > m[2] ? m[0] : m[1] > m[2] ? m[1] : m[2];
        Console.WriteLine("The biggest number:" + b);
        if (m[0] > m[1] && m[0] > m[2])

            Console.WriteLine("The biggest number:" +m[0]);
        else if (m[1] > m[2])

            Console.WriteLine("The biggest number:" + m[1]);
        else
            Console.WriteLine("The biggest number:" + m[2]);
    }
}