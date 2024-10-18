using System;
public class fact
{
    public static void Main(string[] args)
    {
        int i, fact = 1, number;
        Console.Write("Enter the Number: ");
        number = int.Parse(Console.ReadLine());
        for (i = 1; i <= number; i++)
        {
            fact = fact * i;
        }
        Console.Write("Factorial of " + number + " is: " + fact);
    }
}