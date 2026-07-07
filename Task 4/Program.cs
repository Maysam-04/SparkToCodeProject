using System;

namespace Task_4;

class Program
{
    //Task 1 - Personalized Welcome Function

    public static void printwelcomeMessage(string name)
    {
        Console.WriteLine("Welcome to Spark To Code"+name);
    }
   /// ////////////////////////////////////////////////////////////

   // Task 2 - Square Number Function

   public static int Square(int num)
    {
        int result = num * num;
        return result;
    }

   //Task 3 - Celsius to Fahrenheit Function

   public static double CelsiusToFahrenheit(double celsius)
   {
       double fahrenheit = (celsius * 9 / 5) + 32;
       return fahrenheit;
   }

   /// ///////////////////////////////////////////////////////////

   //Task 4 - Fixed Menu Display Function
   public static void DisplayMenu()
   {
       Console.WriteLine("DisplayMenu:");
       Console.WriteLine("1. Start");
       Console.WriteLine("2. Help");
       Console.WriteLine("3. Exit");
       
   }

   /// /////////////////////////////////////////////////////

   //Task 5 - Even or Odd Function
   public static bool IsEven(int N)
   {
       return N % 2 == 0;

   }
   
    static void Main(string[] args)
    {
        printwelcomeMessage( " Molham");
        
        ///////////////////////////////////////
      
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        
        int result = Square(num);
        Console.WriteLine(result);
        
        /////////////////////////////////////////////
        
        Console.WriteLine("Enter a Celsius value:");
        double Celsius = double.Parse(Console.ReadLine());
        
        double fahrenheit = CelsiusToFahrenheit(Celsius);
        Console.WriteLine(fahrenheit);
        
        /////////////////////////////////////////////////

         DisplayMenu();
        
        /////////////////////////////////////////////////
        
        Console.WriteLine("Enter a number");
        int N = int.Parse(Console.ReadLine());
        
        bool isEven = IsEven(N);
        
        if (IsEven(N))
        {
            Console.WriteLine("The number is even");
        }
        else
        {
            
            Console.WriteLine("The number is odd");
        }
    }
        
        
       
    
   
}