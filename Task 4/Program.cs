using System;

namespace Task_4;

class Program
{
    //Task 1 - Personalized Welcome Function

    public static void printwelcomeMessage(string name)
    {
        Console.WriteLine("Welcome to Spark To Code"+name);
    }
    static void Main(string[] args)
    {
        printwelcomeMessage( " Waheeb");
    }
}