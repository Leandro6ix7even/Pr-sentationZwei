using System;

class Program
{
    static void Main()
    {
        int result = Add(10, 5);

        Console.WriteLine("Test wird ausgeführt...");

        if (result == 15)
        {
            Console.WriteLine("Test bestanden");
        }
        else
        {
            Console.WriteLine("Fehler erkannt");
        }

        Console.ReadLine();
    }

    static int Add(int a, int b)
    {
        return a + b;
    }
}