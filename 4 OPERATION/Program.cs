using System;
class program
{
static void Main (string []args)
    {

        Console.Write("Enter First Nunber = ");

        double num1 =Convert.ToDouble(Console.ReadLine());

      Console.Write ("Enter Second Number = ");

        double num2 = Convert.ToDouble(Console.ReadLine());
       
        Console.Write("Enter Any Operator : ");

        string op = Console.ReadLine();

  if (op == "+")
        {
            Console.WriteLine("The Output = " + (num1 + num2));


        }

else  if (op == "-")
        {
            if (num1 > num2)
            {
                Console.WriteLine("The Output = " + (num1 - num2));

            }

            if (num2 > num1)
            {
                Console.WriteLine("The Output = " + (num2 - num1));

            }


        }

 else  if (op == "/")
        {
            if (num1 > num2)
            {
                Console.WriteLine("The Output = " + (num1 / num2));

            }

            if (num2 > num1)
            {
                Console.WriteLine("The Output = " + (num2 / num1));

            }

        }

 else   if (op == "*")
        {
            Console.WriteLine("The Output = " + (num1 * num2));


        }
        else
        {
            Console.WriteLine("Invalid Operator");
        }
        Console.ReadLine();
    }






}