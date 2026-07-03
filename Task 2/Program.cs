using System;

namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer
        Console.Write("Enter a starting number:");
        int startNumber = int.Parse(Console.ReadLine());

        for (int n = startNumber; startNumber >= 1; startNumber--)
        {
            Console.WriteLine( startNumber); 
        }
        Console.WriteLine("Liftoff!" );
    }
}