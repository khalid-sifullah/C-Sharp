using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter any String:");
        string s = Console.ReadLine();
        Console.WriteLine("You have entered: "+s);
        Console.WriteLine("The first character: " + s[0]);
        Console.WriteLine("The Length of string: " + s.Length);
        Console.WriteLine("The index of 'a': " + s.IndexOf('a'));
        Console.WriteLine("The index of Last 'a': " + s.LastIndexOf('a'));
        Console.WriteLine("The String in uppercase: " + s.ToUpper());
        Console.WriteLine("The String in lowercase: " + s.ToLower());
        Console.WriteLine("Does the String start with Khalid: " + s.StartsWith("Khalid"));
        Console.WriteLine("Does the String start with K: " + s.StartsWith("K"));
        Console.WriteLine("Does the String ends with h: " + s.EndsWith('h'));
        Console.WriteLine("Does the String contains Sifullah: " + s.Contains("Sifullah"));
        Console.WriteLine("Does the String contains zidan: " + s.Contains("zidan"));
       
        Console.WriteLine("Does the String equals to Khalid Sifullah: " + s.Equals("Khalid Sifullah"));

        Console.WriteLine("Does the String equals to khalid sifullah: " + s.Equals("Khalid Sifullah",StringComparison.OrdinalIgnoreCase));

    }
}