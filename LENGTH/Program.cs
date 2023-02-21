using System;
class project
{
    static void Main(string[] args)
    {
        string []a =  new string[] { "l", "o", "c", "a", "l", "i", "z", "a", "t", "i", "o", "n" };
        int n = a.Length;
        Console.Write("The length of string \"a\" is:"+n );
        



        string[] s =new string[] { "1,2,3,4,5" };
        int m = s.Length;
        Console.Write("\nThe length of string \"s\" is:" + m);
        
        string b = "KHALID";
        Console.Write("\nThe length of string \"b\" is:" + b.Length);
        Console.Write("\nThe location of \"A\" is:" + b.IndexOf('A'));

    }
}