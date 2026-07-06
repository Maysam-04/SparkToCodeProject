using System;

namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        // Task 1 - Absolute Difference
        
       /* Console.Write("Enter a  first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter a  second number: ");
        int num2 = int.Parse(Console.ReadLine());
        
        int subtraction= num2-num1;
        
        int subtractionresult = Math.Abs(subtraction);
        Console.WriteLine("The final result is :"+subtractionresult);*/
       //////////////////////////////////////////////////////////////////////
       
       //Task 2 - Power & Root Explorer
       
       /*Console.WriteLine("Enter a number: ");
        int powernumber = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter another number: ");
        int sqrnumber = int.Parse(Console.ReadLine());
        
        double result1= Math.Pow(powernumber,sqrnumber);
        double result2 = Math.Sqrt(sqrnumber);
        
        Console.Write("the final result of power is :"+result1 + " & " + "the final result of sqr is:" +result2);*/
        
        ////////////////////////////////////////////////////////////////////////
        
        // Task 3 - Name Formatter
        
        /*Console.Write("Enter your full name: ");
        String Username=Console.ReadLine();
      
        String upperedname= Username.ToUpper();
        String loweredname= Username.ToLower();
        int length = Username.Length;
        Console.WriteLine("the Uppered full name is :" + upperedname);
        Console.WriteLine("the lowered full name is :" + loweredname);
        Console.WriteLine("the length of the full name is :" + length);*/
        
        /////////////////////////////////////////////////////////////
        
        // Task 4 - Subscription End Date
        
       /* Console.Write("Enter the number of days of free trial: ");
        int freetrialnumber = int.Parse(Console.ReadLine());
        
        DateTime startDate = DateTime.Today;
        DateTime endDate = startDate.AddDays(freetrialnumber);
        
        String date = endDate.ToString("yyyy/MM/dd");
        Console.WriteLine(date);*/
        
        ////////////////////////////////////////////////////////////////
        
        //Task 5 - Grade Rounding System
        
       /* Console.Write("Enter your exam score: ");
        double examscore = double.Parse(Console.ReadLine());

        double roundedScore = Math.Round(examscore);
        
        if (roundedScore >=60)
        {
            Console.WriteLine(" pass");
        }
        else if (roundedScore <= 100)
        {
            Console.WriteLine(" fail");
        }

        Console.WriteLine("the rounded score is " + roundedScore);*/
       
       ////////////////////////////////////////////////////////////////
       
       // Task 6 - Password Strength Checker
       Console.WriteLine("Enter a password:");
       string password = Console.ReadLine();
       
       int passwordLength = password.Length;
       bool eightcharacterslong= passwordLength == 8;
       bool containsforbiddenword = password.ToLower().Contains("password");
       
       if ( eightcharacterslong && !containsforbiddenword)
       {
           Console.WriteLine("strong: Password  satisfies the condition.");
       }
       else if ( !eightcharacterslong)
       {
           
           Console.WriteLine("weak: password must be at least 8 characters long.");
       }
       else if ( containsforbiddenword)
       {
           Console.WriteLine("weak: Password contains forbidden words.");
       }

    }
}

