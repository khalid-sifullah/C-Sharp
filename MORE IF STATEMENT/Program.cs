using System;
class IF
{

    static void Main(string[] args)
    {
        Console.Write("Enter Three Values= ");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(GET(x, y, z));
        Console.ReadLine();


    }

    static int GET(int num1, int num2, int num3)
    {

        int result;

        if (num1 >= num2 && num2 >= num3)
        {

            result = num1;

        }
        else if (num2 >= num1 && num2 >= num3)
        {

            result = num2;
        }
        else
        {
            result = num3;

        }

        return result;

    }





}
