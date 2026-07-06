using System;

namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Absolute Difference
        
        Console.Write("Enter a  first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a  second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        int subtraction= num2-num1;
        
        int subtractionresult = Math.Abs(subtraction);
        Console.WriteLine("The final result is :"+subtractionresult);
        
    }
}

