using System;
public class revnum
{
    public static void Main(String[] args)
    {
        int num, reverse = 0;
        Console.WriteLine("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            reverse = reverse * 10;
            reverse = reverse + num % 10;
            num = num / 10;
        }
        Console.WriteLine("Reverse of the number is "+reverse);
    }
}