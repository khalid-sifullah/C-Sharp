using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter Any Sentance:");
        string a = Console.ReadLine();
        Console.Write("Enter Any Character to check its existicity in the sentence and to find out its location:");
      char c  =char.Parse( Console.ReadLine());
        bool found = false;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == c)

            {
                found = true;
                Console.WriteLine("The character " + c + " is found and its position is:" + i);
            }
            
        }


        if (found==false)
        {
            Console.WriteLine("The character " + c + " is not found");
        }
        
    }
}