using System;
class program
{
    static void Main(string[]args)
    {
        int n, y = 0;
        Console.WriteLine("Enter the numbers of statement:");
        n = int.Parse(Console.ReadLine());
        for(int i=0;i<n;i++)
        {
            string x=Console.ReadLine();
            if (x[1] == '+')
                y = y + 1;
            else 
                    
                y = y - 1;
            
        }
        Console.WriteLine(y);
    }
}