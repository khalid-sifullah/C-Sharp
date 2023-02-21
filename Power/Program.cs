using System;
class program
{
static void Main(string[]args)
    {
        int x, y;
        Console.Write("Enter the value of base:");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entert the value of power:");
        y = Convert.ToInt32(Console.ReadLine());
        int z = getpower(x, y);
        Console.WriteLine("The Result :"+z);



    }

static int getpower(int b, int p)
    {

        int r = 1;
        for(int i=0;i<p;i++)
        {
            r = r*b;

        }
        return (r);
    }


}
