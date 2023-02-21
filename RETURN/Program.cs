using System;
class RETURN
{
    static void Main(string[]args)
    {
        Console.Write("Enter The Value = ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The Cubic Value=" + cube(x));



        Console.ReadLine();

    }

    static int cube(int num)
        {
       
        int result = num * num * num;
        return result;




    }



}