using System;
class program
{
    static void Main(string[]args)
    {
        try
        {
            Console.Write("Enter a Number: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another Number: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Rusult after division : " +(x / y));

        }
        catch(Exception i)
        {


            Console.Write(i.Message);

        }

    }




}