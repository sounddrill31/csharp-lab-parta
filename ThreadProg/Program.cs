using System.Threading;
using System;
namespace ThreadingDemo
{
    class TreadProg
    {
        public static void Main(String[] args)
        {
        Thread t = Thread.CurrentThread;
        // By Default, The Thread doesn't have  a name
        t.Name = "Main Thread";
        Console.WriteLine("Thread Name: " + t.Name);
        Console.WriteLine("Currently Executing Thread: " + Thread.CurrentThread.Name);}
    }    
}