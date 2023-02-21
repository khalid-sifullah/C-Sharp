using System;
class program
{
    static void Main(string[]args)
    {

        int i;
        Console.Write("Enter the valur of string s:");
       string s= Console.ReadLine().ToLower ();  // TO CONVERT ANY LETTER WHETHER UPPER CASE OF LOWER CASE LOWER CASE LETTER
        Console.Write("Enter the valur of string p:");
        string p = Console.ReadLine().ToLower();
        for (i=0;i<s.Length;i++)
         {
           
            if (s == p)
            {
                Console.WriteLine("0");
                break;
            }
           if (s[i]>p[i])
            {
                Console.WriteLine("1");
                break;
            }
            if (s[i] < p[i])
            {
                Console.WriteLine("-1");
                break;
            }

        }
          
    }
}