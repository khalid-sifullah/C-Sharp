using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter Any Character:");
        char x = char.Parse(Console.ReadLine());
        if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u' || x == 'A' || x == 'E' || x == 'I' || x == 'O' || x == 'U')

            Console.WriteLine(x+" is a vowel.");
        else

            Console.WriteLine(x + " is a consonant.");

    }



}