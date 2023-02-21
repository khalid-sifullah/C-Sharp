using System;
class program
{
    struct engine
    {
        public string brand;
        public string model;
        public int year;
        public float price;
    }

    static void Main(string[]args)
    {
        engine engine1;
        engine engine2;

        // ENGINE1 INFORMATION

        Console.Write("What is the brand of engine1:");
       engine1.brand = Console.ReadLine();

        engine1.model ="Trent 1000";
        Console.Write("What is the launch year of engine1:");
        engine1.year = int.Parse(Console.ReadLine());
        Console.Write("What is the price of engine1:");
        engine1.price = float.Parse(Console.ReadLine());

        // ENGINE2 INFORMATION
        Console.Write("What is the brand of engine2:");
        engine2.brand = Console.ReadLine();

        engine2.model = " GE T408 ";
        Console.Write("What is the launch year of engine2:");
        engine2.year = int.Parse(Console.ReadLine());
        Console.Write("What is the price of engine2:");
        engine2.price = float.Parse(Console.ReadLine());

        // NOW SHOW THE ENGINE INFORMATION

        Console.WriteLine(" The Brand of engine1 is:"+engine1.brand);
        Console.WriteLine(" The Model of engine1 is:" + engine1.model);
        Console.WriteLine(" The launch year of engine1 is:" + engine1.year);
        Console.WriteLine(" The Price of engine1 is:" + engine1.price);

        Console.WriteLine(" The Brand of engine2 is:" + engine2.brand);
        Console.WriteLine(" The Model of engine2 is:" + engine2.model);
        Console.WriteLine(" The launch year of engine2 is:" + engine2.year);
        Console.WriteLine(" The Price of engine2 is:" + engine2.price);


    }
}