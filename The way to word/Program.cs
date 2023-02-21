using System;
class program
{
    static void Main(string[] args)
    {
        /*string[] a = new string[] { "l", "o", "c", "a", "l", "i", "z", "a", "t", "i", "o", "n" };
       
        int m = a.Length;
        Console.Write(a[0]);
        Console.Write( m - 2);
       Console.Write(a[m-1]);*/


        int n = int.Parse(Console.ReadLine());
        

        for (int i = 0; i < n; i++)
        {
           string w = Console.ReadLine();
            if (w.Length < 11)
            {
                Console.WriteLine(w);
            }
            else

            { 
            Console.Write(w[0]);
            Console.Write(w.Length - 2);
            Console.Write(w[w.Length - 1]);
                Console.WriteLine("\n");
            }
        }
    }
}