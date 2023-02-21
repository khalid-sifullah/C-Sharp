using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the String:");
        string s = Console.ReadLine().ToLower();
        Char[] c = s.ToCharArray();
        Array.Sort(c);
        Console.Write(c);
    }
}
