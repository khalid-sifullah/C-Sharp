using System;


public class person
{

    public string name;
    public int age;
    public void g()
    {
       
        Console.WriteLine("Assalamualikum. I am " + name + " and I am " + age + ".");

    }


}
class program
{

    static void Main(string[] args)
    {
        person person1 = new person();

        person1.name = "Khalid";

        person1.age = 21;

        person1.g();

    }





}