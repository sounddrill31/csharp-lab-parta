using System;
public class fibo
{
    public static void Main(string[] args)
    {
        int n = 10;
        int a = 0;
        int b = 1;
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a);
            c = a + b;
            a = b;
            b = c;
        }
    }
}