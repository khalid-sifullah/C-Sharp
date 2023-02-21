using System;
class program
{
    static void Main(string[] args)
    {
        int[,] arr1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] arr2 = new int[,] { { 11, 22, 33 }, { 44, 55, 66 } };
        int[,] arr3 = new int[2,3];
        arr3[0, 0] = 9;
        arr3[0, 1] = 8;
        Console.WriteLine(arr1[1, 2]);
        Console.WriteLine(arr2[0, 1]);
        Console.WriteLine(arr3[0, 0]);
    }
}