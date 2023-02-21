using System;
class program
{
    static void Main(string[]args)
    {
        int n = int.Parse(Console.ReadLine());
        int a, b, c;
        int count = 0;
        
        for (int i=1;i<=n;i++)
        {

            string[] str = Console.ReadLine().Split();
             a = int.Parse(str[0]);
            b = int.Parse(str[1]);
            c = int.Parse(str[2]);
            if ((a + b + c) >= 2)
                count = count + 1;

        }
        Console.WriteLine(count);
    }
}



