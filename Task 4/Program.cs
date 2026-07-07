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
        
    }
        
        
       
    
   
}