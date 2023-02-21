using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter the String:");
        string s = Console.ReadLine();
        int i, count=0;
        for(i=0;i<s.Length;i++)
        {
            if(s[i]==' '||s[i]=='\n')
            {
                count = count + 1;
            }
        }
        Console.Write("Number of word:" + (count+1));
    }
}