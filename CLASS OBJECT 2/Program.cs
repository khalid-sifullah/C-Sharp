using System;
public class student
{
    public string name;
    public double gpa;
    public int id;
    public student(string n, double g, int i)
    {

        name = n;
         gpa=g;
        id = i;
    }
    public bool e()
    {
        if (gpa > 3.6)
            return true;

        else
            return false;

    }


}

class program
{
    static void Main(string[] args)
    {
        string a;
        int m;
       
        Console.Write(" Enter Student Name:");
        a= Console.ReadLine();
        Console.Write("Enter ID:");
        m = Convert.ToInt32(Console.ReadLine());
        var s1 = new student(a,4,m);

        Console.WriteLine("Student Name:"+s1.name);
        Console.WriteLine("Student ID:"+s1.id);
        Console.WriteLine("Student GPA:"+s1.gpa);
        Console.WriteLine(s1.e());

        var s2 = new student("khalid",3.56, 13);
        Console.WriteLine("Student Name:" + s2.name+ "\nStudent ID:"+s2.id+ "\nStudent GPA:"+s2.gpa);
       
        Console.WriteLine(s2.e());
        

    }

}
