using System;
class program
{
    static void Main(string[] args)
    {
        string secret = "YA";
        String guess = "";
        int count = 0;
        int limit = 3;
        bool OutOfGasses = false;
        while (guess != secret && !OutOfGasses)
        {

            if (count < limit)
            {
                Console.Write("Enter Your Gauss Word(Two Digit): ");
                guess = Console.ReadLine();
                count = count + 1;

            }
            else
            {
                OutOfGasses = true;

            }

        }
if(OutOfGasses)
        {

            Console.Write("Game Over!! Good Try...");
        }
        else
        {

            Console.Write("Excellent!! You Win.");
        }

        Console.ReadLine();
    }
}