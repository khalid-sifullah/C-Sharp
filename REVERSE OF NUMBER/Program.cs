using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter any number:");
        int n = Convert.ToInt32(Console.ReadLine());
        reverse(n);
    }
    static void reverse(int a)
    {

        int rem=0, rev=0;
        while (a!=0)
        {
            rem = a % 10;
            rev = rev*10 + rem ;
           a= a / 10;


        }
        Console.WriteLine("The reverse  is:" + rev);

    }

}