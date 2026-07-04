using System;

namespace Task_2;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Countdown Timer
        /*Console.Write("Enter a starting number:");
        int startNumber = int.Parse(Console.ReadLine());

        for (int n = startNumber; n >= 1; n--)
        {
            Console.WriteLine(n); 
        }
        Console.WriteLine("Liftoff!" );*/
        ///////////////////////////////////////
        
        // Task 2 - Sum of Numbers 1 to N
       /* Console.Write("Enter a whole number N :");
        int wholeNumber = int.Parse(Console.ReadLine());

        int sum = 0;
        int N; 
        for ( N = 1; N <= wholeNumber; N++)
        {
            sum = sum + N;
        }
        Console.WriteLine(sum);*/
       //////////////////////////////////////////
       
       // Task 3 - Multiplication Table
       Console.Write("Enter a number:");
       int number = int.Parse(Console.ReadLine());
       
       int i;
       for (i = 1; i <= 10; i++)
       {
           Console.WriteLine( number + "*" +i +"=" + number* i ); 
       }
       
       

    }
}