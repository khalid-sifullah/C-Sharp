using System;
class program
{
    static void Main(string[] args)
    {
        int n, i, k,x,y, c = 0;
        string[] str = Console.ReadLine().Split(' ');
         n = int.Parse(str[0]);
         k = int.Parse(str[1]);
        string[] a = new string[100];
       /* Console.Write("Enter the Value of n:");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter the Value of k:");
        k = int.Parse(Console.ReadLine());*/
        for (i = 0; i < n; i++)
        {
            Console.Write("Enter the Value of a["+i+"]:");
            a[i] = Console.ReadLine();
        }
        
        for(i=0;i<n;i++)
        {
            x = int.Parse(a[i]);
            y = int.Parse(a[k-1]);
            if (x>=y && x>0)
            {
                c = c + 1;
            }
        }
        Console.WriteLine(c);
    }
}