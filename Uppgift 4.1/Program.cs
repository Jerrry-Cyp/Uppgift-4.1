using System;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 10; i <= 30; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(250);
            Console.Clear();
        }
        
        for (int x = 200; x >= 180; x--)
        {
            Console.WriteLine(x);
            Thread.Sleep(250);
            Console.Clear();
        }
        
        for (int h = 1000; h <= 1400; h+=50)
        {
            Console.WriteLine(h);
            Thread.Sleep(250);
            Console.Clear();
        }
    }
}