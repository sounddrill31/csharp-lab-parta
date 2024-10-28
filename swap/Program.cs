using System;
public class swap
{
    public static void Main(String[] args)
    {
        int num1, num2, temp;
        Console.WriteLine("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Before swapping: num1 = "+num1+" num2 = "+num2);
        num1 = num1 + num2;
        num2 = num1 - num2;
        num1 = num1 - num2;
        Console.WriteLine("After swapping: num1 = "+num1+" num2 = "+num2);
    }
}