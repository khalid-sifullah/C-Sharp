using System;
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Enter the cost of the first banana, initial number of dollars the soldier has and number of bananas he wants.");
        string[] p = Console.ReadLine().Split(' ');
        int k = int.Parse(p[0]);
        int n = int.Parse(p[1]);
        int w = int.Parse(p[2]);
        int x = 0;
        for(int i=1;i<=w;i++)
        {
            x = x + i * k; // total price
        }
        //Console.Write(" Soldier will have to borrow:" + (x - n)+" dollars");
        
        Console.WriteLine((x - n) > 0 ? x - n : 0);
    }

}