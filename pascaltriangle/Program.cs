using System;
using System.Security.Cryptography.X509Certificates;
public class pascaltriangle
{
    public static void Main(String[] args)
    {
        int i, j, k, n;
        Console.WriteLine("Enter the number of rows: ");
        n = int.Parse(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < n - i - 1; j++)
            {
                Console.Write(" ");
            }
            int number = 1;
            for (k = 0; k <= i; k++)
            {
                Console.Write(number + " ");
                number = number * (i - k) / (k + 1);
            }
            Console.WriteLine();
        }
    }
}