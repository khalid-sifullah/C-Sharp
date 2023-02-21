using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Enter any character :");
        char a = char.Parse(Console.ReadLine());

        Console.Write("\nThe ASCII value of" + a + "is:" + (int)a);
        Console.Write("Now Printing out the character between 0 to 127:");
        for (int i = 0; i <= 127; i++)
        {
          
            Console.WriteLine(i+":"+(char)i);
          

        }


    }




}