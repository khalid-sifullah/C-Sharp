
using System;


    class STRING
    {
        static void Main(string[] args)
        {
        string[] names = new string[5] { "A", "B", "C", "D", "E" };

        Console.WriteLine("The Frist letter: " + names[0]);


            string x = "I am" + " Khalid Sifullah.";
            string y = "BSMRAAU";

            Console.WriteLine(x);

            Console.WriteLine(" I am styding at " + y + ".  ");


            Console.WriteLine(" My ID is \"20014013\".  ");

            Console.WriteLine("The length if x = " + x.Length);

            Console.WriteLine("The uppercase and lower case of x are \"    " + x.ToUpper() + "     \" and \"     " + x.ToLower() + "   \".   ");

            Console.WriteLine(y.Contains('B'));

            Console.WriteLine(y.Contains("BO"));

            Console.WriteLine("The First and Third Letter of y are " + y[0]+ "  and "+ y[2]+ ".   ");

            Console.WriteLine("The Position OF First and Third Letter of y are " + y. IndexOf('B')+ "  and " + y.IndexOf('M') + ".   ");

            Console.WriteLine(" Letter between B AND R is\" " + y.Substring(0, 3)+ "\"   " );


           

        }

    }


