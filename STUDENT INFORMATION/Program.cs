using System;
public class student
{
    public string nam;

    public int b;
    public int e;
    public int m;
    public int s;
    public student(string name,int ban, int eng, int mat,int sci)
    {
        nam = name;
        b = ban;
        e = eng;
        m = mat;
        s = sci;
    }
}
class program
{
    static void Main(string[]args)
    {
        Console.Write("Enter Student ID:");
            int id = Convert.ToInt32(Console.ReadLine());
        var s1 = new student("KHALID",67,87,65,89);
        var s2 = new student("ZIDAN", 87, 97, 85, 80);
        if (id == 13)
        {
            Console.WriteLine("Stdent Name:"+s1.nam);
            Console.WriteLine("Bangla:"+s1.b);
            Console.WriteLine("English:"+s1.e);
            Console.WriteLine("Mathematics:"+s1.m);
            Console.WriteLine("Science:"+s1.s);

        }
        else if (id == 14)
        {
            Console.WriteLine("Stdent Name:" + s2.nam);
            Console.WriteLine("Bangla:" + s2.b);
            Console.WriteLine("English:" + s2.e);
            Console.WriteLine("Mathematics:" + s2.m);
            Console.WriteLine("Science:" + s2.s);
        }
        else
            Console.WriteLine("Please enter valid ID.Thank You.");

    }
}
