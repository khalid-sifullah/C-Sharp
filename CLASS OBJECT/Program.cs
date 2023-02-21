using System;
public class student
{
    public string name;
    public double gpa;
    public int id;
    public student (string n, double g, int i )
    {

        name = n;
        g = gpa;
        id = i;
    }



}
class program
{
    static void Main(string[]args)
    {
        var s1 = new student("khalid", 3.98, 13);
        Console.WriteLine(s1);

    }

}