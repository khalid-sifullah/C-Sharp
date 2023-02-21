using System;
class METHOD
{
    static void Main(string[]args)
    {
        box();
        method("KHALID", 100);
        method("SIFULLAH", 90);


        Console.ReadLine();
    }

    static void box()
    {

        Console.WriteLine(" Assalamualaikum.");
    }

    static void method(string name,int marks)
    {

        Console.WriteLine("How is going," + name + "?? Congratulations!! You have scored " + marks);


    }


}