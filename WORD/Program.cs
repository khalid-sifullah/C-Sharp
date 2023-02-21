using System;
class program
{
    static void Main(string []args)
    {
        Console.Write("Enter the word:");
        string s = Console.ReadLine();
        int u = 0, l = 0;
        for(int i=0;i<s.Length;i++)
        {
            if ((int)s[i] > 96)
                l = l + 1;
            else
                u = u + 1;
        }

        if ( u>l)
        {
           
            Console.Write(s.ToUpper());
        }
        else
        {
            Console.Write(s.ToLower());
        }

       
    }
}