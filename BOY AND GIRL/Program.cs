using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter any string:");
        string s = Console.ReadLine();
        string p = string.Empty;
        for(int i=0;i<s.Length;i++)
        {
            if(!p.Contains(s[i]))
            {
                p += s[i];
            }
        }
        
        Console.WriteLine((p.Length %2== 0) ? "CHAT WITH HER!" : "IGNORE HIM!");
    }
}