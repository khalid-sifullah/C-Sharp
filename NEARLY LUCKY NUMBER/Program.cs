
using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter the number:");
        string n = Console.ReadLine();
        int count = 0;
        
        for (int i = 0; i <= n.Length-1; i++)
        {
            if (n[i] == '4'|| n[i]=='7')
            {
                count = count + 1;
            }
        }
        
        if (count == 7 || count == 4)
            Console.Write("YES");
        else
            Console.Write("NO");
    }
}