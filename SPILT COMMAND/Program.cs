using System;
class program
{
    static void Main(string[] args)
    {
        string str = "I AM KHALID SIFULLAH. I AM FROM BHOLA.";
       var p = str.Split(".");
        
        foreach (var s in p)
        {
            Console.WriteLine(s);
        }


        string str2 = "I, AM, KHALID, SIFULLAH. I, AM, FROM, BHOLA.";
        var w = str2.Split(",");
        foreach (var s in w)
        {
            Console.WriteLine(s);
        }

        string p = "1,2,3,4,5";
        
        foreach (var s in p.Split(","))
        {
            Console.WriteLine(s);
        }
    }
}