// Find Square using Subroutines and Functions

using System;
class SubSquare
{
    public static int Square(int num)
    {
        return num * num;
    }
    public static void Main(String[] args)
    {
        int number, result;
        Console.WriteLine("Enter a number: ");
        number = int.Parse(Console.ReadLine());
        result = Square(number);
        Console.WriteLine("Square of the number is "+result);
    }
}