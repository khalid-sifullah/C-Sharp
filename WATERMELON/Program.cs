using System;
class program
{
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        if (n % 2 == 0 && n != 2)

            Console.WriteLine("YES");


        else
            Console.WriteLine("NO");

        //Console.WriteLine((n % 2 == 0 && n != 2) ? "Yes" : "No");  ***ANOTHER METHOD
    }
}



