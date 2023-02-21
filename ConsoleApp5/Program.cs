using System;

public class customer
{
    public int id;
    public string name;

    public customer(int x, string y)
    {
        this.id = x;
        this.name = y;
    }
    class program
    {
        static void Main(string[] args)
        {

            var customer = new customer(1, "Khalid");
            Console.WriteLine(customer.id);

            Console.WriteLine(customer.name);
        }



    }
}