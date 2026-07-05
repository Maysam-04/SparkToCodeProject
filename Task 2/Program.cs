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
        /* Console.Write("Enter a number:");
         int number = int.Parse(Console.ReadLine());

         int i;
         for (i = 1; i <= 10; i++)
         {
             Console.WriteLine( number + "*" +i +"=" + number* i );
         }*/
        ///////////////////////////////////////////////////////

        // Task 4 - Password Retry
        /*string CorrectPassword = "Spark 2026";
        Console.WriteLine("Enter the password :");
        string password = Console.ReadLine();
        while (password != CorrectPassword)
        {
            Console.WriteLine("Incorrect password , try again");
            Console.WriteLine("Enter the password :");
            password = Console.ReadLine();
        }

        Console.WriteLine("Access Granted");
        {

        }*/
        /////////////////////////////////////////
        //Task 5 - Number Guessing Game
        /*{
            int SecretNum = 42;
            int guess;
            int attempts = 0;

            do
            {
                Console.Write("Guess the number: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;


                if (guess > SecretNum)
                {
                    Console.WriteLine(" too high");
                }
                else if (guess < SecretNum)
                {
                    Console.WriteLine(" too low");
                }

            } while (guess != SecretNum);
            Console.WriteLine("Attempts:" + attempts);

        }*/
        ////////////////////////////////////

        //Task 6 - Safe Division Calculator
        /* try
         {
             Console.WriteLine("Enter the first number:");
             int firstNumber = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter the second number:");
             int secondNumber = int.Parse(Console.ReadLine());

             int div = firstNumber / secondNumber;
             Console.WriteLine("Result is :"+div);
         }
         catch (DivideByZeroException )
         {
             Console.WriteLine( "second number is zero");

         }
         catch (FormatException )
         {
             Console.WriteLine( "number is invalid");
         }*/
        //////////////////////////////////////////

        //Task 7 - Repeating Menu with Exit Option
        /* int choice=0;
         while (choice != 3)
         {
             Console.WriteLine("1.Hello");
             Console.WriteLine("2.Good Morning");
             Console.WriteLine("3.exit");

             try
             {
                 Console.Write("Enter choice num:");
             choice = int.Parse(Console.ReadLine());

             switch (choice)
             {
                 case 1:
                     Console.WriteLine("Hello");
                     break;
                 case 2:
                     Console.WriteLine("Good Morning");
                     break;
                 case 3:
                     Console.WriteLine("exit");
                     break;
                 default:
                     Console.WriteLine("Incorrect choice");
                     break;
             }
             }
             catch (FormatException)
             {
                 Console.WriteLine("invalid number");
             }
         }*/

        ////////////////////////////////////////////////

        //Task 8 - Sum of Even Numbers Only
       /* Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        int sum = 0;
        int N;
        for (N = 1; N <= number; N++)
        {
            if (N % 2 == 0)
            {
                sum = sum + N;

            }
        }
        Console.WriteLine("The final sum is : " + sum);*/

      ///////////////////////////////////////////
      
      // Task 9 - Validated Positive Number Input
      int sum = 0;
      int number=0;
      int i;
      bool vaildinput=false;
        do
        {
            try
            {
                Console.Write("Enter a positive  number: ");
                 number = int.Parse(Console.ReadLine());
                 
                 if ( number <=0)
                 {
                     Console.WriteLine(" you entered a zero or negative number ");
                    number= int.Parse(Console.ReadLine());
                 }
                 else
                 {
                     Console.WriteLine(" vaild input true");

                 }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Not a valid number");
            }
            
        } while ( ! vaildinput);
        
        for ( i = 1; i <=number;i++)
        {
            sum = sum + i;
                
        }
        Console.WriteLine(" the final sum is: "+sum);
    }
}









    

   





    


    



    

