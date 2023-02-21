using System;
public class song
{
    public string title;
    public string artist;
    public int duration;
    public static int count=0;

public song(string t,string a, int d)
    {
        title = t;
        artist = a;
        duration = d;
        count++;

    }
}
class program
{
static void Main(string[]args)
    {
        Console.WriteLine(song.count);
        var h= new song ("a","b", 200);
        Console.WriteLine(h.title);
        Console.WriteLine(song.count);


        var i = new song("m", "n", 100);
        Console.WriteLine(i.title);
        Console.WriteLine(song.count);




    }




}