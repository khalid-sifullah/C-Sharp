using System;
class program
{

   public static void Main(string[]args)
    {
        unsafe
        {
            int a=3;
            int* p=&a;
            Console.WriteLine("The value of a="+a);
            Console.WriteLine("The value of a=" +*p);
            Console.WriteLine("The address of a=" + (int)p);
      
        }

    }


}