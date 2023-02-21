using System;

class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the namber of stones:");
        int i,count = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the colour of stones:");
        string s = Console.ReadLine();
        for (i=0;i<n-1;i++)
        {
            if (s[i] == s[i + 1])
                count = count + 1;
        }
        Console.WriteLine(count);
    }
}
