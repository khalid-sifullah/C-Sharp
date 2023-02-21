using System;
class IF 
{
    static void Main(string[]args)
    {

        bool male = false;
        bool tall = false;
        if(male && tall)
        {
            Console.WriteLine("You are Tall and Male");

        }
        else if(male && !tall)
            {


            Console.WriteLine("You are Tall and Male");


        }

        else
        {
            Console.WriteLine("You are not Tall or Male or both");

        }



        Console.ReadLine();



    }







}