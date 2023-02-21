using System;
class program
{
    static void Main(string[] args)
    {

        Console.Write("Enter The Initial Input value= ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter The Msximum  Input Limit= ");
        int y = Convert.ToInt32(Console.ReadLine());

        do
        {

            Console.WriteLine("Input value= " + x);
            x = x + 1;


        } while (x <= y);


            Console.ReadLine();
    }






}
