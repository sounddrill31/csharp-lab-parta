using System;
public class sumdigits
{
    public static void Main(string[] args)
    {
        int n, sum = 0, r;
        Console.Write("Enter the Number: ");
        n = int.Parse(Console.ReadLine());
        while (n > 0)
        {
            r = n % 10;
            sum = sum + r;
            n = n / 10;
        }
        Console.Write("Sum of Digits is: " + sum);
    }
}