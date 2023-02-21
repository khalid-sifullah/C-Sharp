using System;
class program
{
    static void Main(string[]argw)
    {
        int n, m,p,c=0;
         Console.Write("Enter the Value of m and n:");
        /* Console.Write("Enter the Value of m:");
          m = int.Parse(Console.ReadLine());
         Console.Write("Enter the Value of n:");
         n = int.Parse(Console.ReadLine());*/
        string[] s = Console.ReadLine().Split(' ');  // to take two or more variable in one line..

        m = int.Parse(s[0]);
        n = int.Parse(s[1]);
        p = m * n;
        c = p / 2;
        Console.WriteLine(c);
    }
}