using System;
class program
{
    static void Main(string[]args)
    {
        Console.Write("Welcome to BD Shop||||\n press 1 for pijja\n press 3 for berger\n press 3 for water\n Enter any number:");
        int n =Convert.ToInt32( Console.ReadLine());
        int a=0, d=0, c=0;
        switch (n)
        {
            case 1:
                Console.Write("Number of pijja:");
                int p = Convert.ToInt32(Console.ReadLine());
                 a = p * 100;

                break;
            case 2:
                Console.Write("Number of berger:");
                int b= Convert.ToInt32(Console.ReadLine());
                 d= b * 50;

                break;
            case 3:
                Console.Write("Number of water:");
                int w= Convert.ToInt32(Console.ReadLine());
                 c = w * 10;

                break;
            default:
                Console.Write("Enter desired number.");
                break;
               
                
        }
        int t = a + d + c;
        Console.Write("Total price:"+t);


    }
}