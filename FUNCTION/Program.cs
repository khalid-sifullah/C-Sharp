

using System;
   
class FUNCTION

{
    static void Main(string[]args)
    {
        Console.Write("Enter The Name : ");
        string name = Console.ReadLine();

        Console.Write("Enter The Score = ");
        int score = Convert.ToInt32(Console.ReadLine());




        box();
        function(name, score);



    }


    static void box()
    {
        Console.WriteLine("Assalamualikum.");


    }

    static void function(string name,int score)
    {

        Console.WriteLine("How is going," + name + "?? Congratulations!! You have scored=" + score);




    }







}
