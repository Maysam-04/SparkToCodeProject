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
   
    static void Main(string[] args)
    {
        printwelcomeMessage( " Molham");
        
        ///////////////////////////////////////
      
        Console.WriteLine("Enter a number:");
        int num = int.Parse(Console.ReadLine());
        
        int result = Square(num);
        Console.WriteLine(result);
        
    }
        
        
       
    
   
}