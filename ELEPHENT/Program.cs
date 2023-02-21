using System;
class program

{
    static void Main(string[]args)
    {
        Console.Write("Enter the distance of Elephent house:");
        int x = int.Parse(Console.ReadLine());
        int c = x / 5;
        int p = x %5;
        int k = p / 4;
        int v= p % 4;
        int w = v / 3;
        int q= v %3;
        int z = q/ 2;
        int m= q % 2;
        int n = m / 2;
        int r = m% 2;
        int s = c + k + w + z + n + r;
        Console.Write("Minimum number of step:"+s);
        //Console.Write(s);

        /* *** Alternative way 
         s=(x+4)/5;
        Console.Write("Minimum number of step:"+s);

         */


    }
}