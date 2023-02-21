using System;
public class movie
{
    public string title;
    public string director;
    private string rating;

public movie (string t, string d, string r)
    {
        title = t;
        director = d;
        Rating = r;

    }
    public string Rating
    {
get { return rating; }
        set
        {
            if (value=="G"|| value == "PG" || value == "G" || value == "P-134G" )
            {
                rating = value;

            }
            else
            {
                rating = "NR";
            }

        }


    }


}
class program
{
    static void Main(string[]args)
        {
        movie a = new movie("the", "f", "G");
        Console.WriteLine(a.title);

        Console.WriteLine(a.director);
        Console.WriteLine(a.Rating);
    
        var b = new movie("s", "t", "m");
        Console.WriteLine(b.Rating);

        b.Rating = "PG";
        Console.WriteLine(b.title);

        Console.WriteLine(b.director);
        Console.WriteLine(b.Rating);
        Console.WriteLine("Enter c's title: ");

        string w = Console.ReadLine();
        var c = new movie(w, "t", "m");
        Console.Write(c.title);



    }




}        


