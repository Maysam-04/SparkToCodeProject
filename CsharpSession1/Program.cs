using System;

namespace CsharpSession1;

class Program
{
    static void Main(string[] args)
    {
        //program to show Welcome message
  /*Console.Write("  Please Enter Your Name:  ");
  String UserName = Console.ReadLine();
  
  Console.Write("  Please Enter Your Age:  ");
  int UserAge = int.Parse(Console.ReadLine());
  
  Console.WriteLine("Please Enter Your Salary:");
  float UserSalary = float.Parse(Console.ReadLine());
  Console.WriteLine("Hello " + UserName + "  Welcome to Spark" );*/
  ///////////////////////////////////////////////////////////////
 /* Console.WriteLine("Enter first number:");
  float FirstNumber = float.Parse(Console.ReadLine());
  
  Console.WriteLine("Enter second number:");
  float SecondNumber = float.Parse(Console.ReadLine());

  float AdditionResult  = FirstNumber + SecondNumber;
  float SubtractionResult = FirstNumber - SecondNumber;
  float MultiplicationResult = FirstNumber * SecondNumber;
  float DivisionResult = FirstNumber / SecondNumber;
  float ReminderResult = FirstNumber % SecondNumber;
  bool comparisonResult = FirstNumber == SecondNumber;

  bool testResult = !(10 > 5);
  
  Console.WriteLine("Addition Result:"  + AdditionResult);
  Console.WriteLine("Subtraction Result:"  + SubtractionResult);
  Console.WriteLine("Multiplication Result:"  + MultiplicationResult);
  Console.WriteLine("Division Result:"  + DivisionResult);
  Console.WriteLine("Reminder Result:"  + ReminderResult);
  Console.WriteLine("Comparison Result:"  + comparisonResult );*/
//////////////////////////////////////////////////////////////////////////////////

/*Console.WriteLine("Enter your degree");
float degree = float.Parse(Console.ReadLine());

if (degree >= 0 && degree < 50)
{
   Console.WriteLine("You failed"); 
}
else if (degree >= 50 && degree < 60)
{
   Console.WriteLine("You Passed with Grade: D"); 
}
else if (degree >= 60 && degree < 70) 
{
    Console.WriteLine("You Passed with Grade: C"); 
}
else if (degree >= 70 && degree < 80) 
{
    Console.WriteLine("You Passed with Grade: B"); 
}
else if (degree > 80)
{
    Console.WriteLine("You Passed with Grade: A");
}
else
{
    Console.WriteLine("You entered wrong number");
}*/
//////////////////////////////////////////////////////////

Console.WriteLine("Welcome to main menu:");
Console.WriteLine("1. Deposite");
Console.WriteLine("2. Withdraw");
Console.WriteLine("3. Balance check");

Console.WriteLine("  Please choose an Option:  ");
int Option = int.Parse(Console.ReadLine());

switch (Option)
{
    case 1:
       Console.WriteLine("Deposited");
        break;
    case 2:
        Console.WriteLine("Withdrawed");
        break;
    case 3:
        Console.WriteLine(" Your Balance =  ");
        break;
    
        default:
           System. Console.WriteLine( " Please  choose a correct Option");
            break;
}
   


    }
}