using System;
class program
{

    static void Main(string[] args)
    {
        Console.Write("Enter The Number Of Day: ");
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Today is " + day(num)+".");
        Console.ReadLine();
    }

    static string day(int daynum)
    {
        string dayname;

        
        switch (daynum)
        {

            case 0:
                dayname = "Saturday";
                break;

            case 1:
                dayname = "Sunday";
                break;

            case 2:
                dayname = "Monday";
                break;
            case 3:
                dayname = "Tuesday";

                break;
            case 4:
                dayname = "Wednesday";
                break;

            case 5:
                dayname = "Thursday";
                break;
            case 6:
                dayname = "Friday";

                break;
            default:
                dayname = "Invalid Day Number";

                break;

        }
        return dayname;



    }


}