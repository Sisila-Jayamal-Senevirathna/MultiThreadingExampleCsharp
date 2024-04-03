using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread newThread = new Thread(new ThreadStart(PrintNumbers));
        newThread.Start();

        Thread newThread2 = new Thread(new ThreadStart(PrintNames));
        newThread2.Start();
    }


    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine("Thread 1: " + i);
            Thread.Sleep(500);
        }
    }

    static void PrintNames()
    {
        String[] Names = { "Sisila", "Shaki", "Shashi", "Sisi", "Sunny" };

        for (int i = 0; i <= 4; i++)
        {
            Console.WriteLine("Thread 2: " + Names[i]);
            Thread.Sleep(500);
        }

    }

}


