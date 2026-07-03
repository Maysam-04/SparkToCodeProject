using System;

namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer
        Console.Write("Enter a starting number:");
        int startNumber = int.Parse(Console.ReadLine());

        for (int n = startNumber; n >= 1; n--)
        {
            Console.WriteLine(n); 
        }
        Console.WriteLine("Liftoff!" );
        ///////////////////////////////////////
        
        // Task 2 - Sum of Numbers 1 to N
        Console.WriteLine("");
    }
}