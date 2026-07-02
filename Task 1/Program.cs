namespace Task_1;

class Program
{
    static void Main(string[] args)
    {
        //Task1:Personal Info Card
       /* const String Name = "Adam";
        Console.Write(" Name: " + Name);
        const int Age = 22;
        Console.Write(" Age: " + Age);
        const double Height = 16.9;
        Console.Write(" Height: " + Height);
        const bool Student = true;
        Console.Write(" Student: " + Student);*/
         
       //Task2:  Rectangle Calculator
       /* Console.WriteLine("Enter the Lenght of Rectangle:");
        int length = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the Width of Rectangle:");
        int Width = int.Parse(Console.ReadLine());

        int Area = length * Width;
        int Perimeter = 2* (length +Width);
        
        Console.WriteLine("The area is: " +Area + " The perimeter is: " + Perimeter);*/
        
       //Task 3:Even or Odd Checker
      /*Console.WriteLine("Enter a num:"); 
      int num = int.Parse(Console.ReadLine());
      if (num % 2 == 0)
      {
       Console.WriteLine("It is Even");
      }
      else if  (num % 3 == 0)
      {
       Console.WriteLine("It is Odd");
      }
      else
      {
       Console.WriteLine("It is neither Even nor Odd");
      }*/
       
       //Task 4:Voting Eligibility
       /*Console.WriteLine("Enter your age:");
       int age = int.Parse(Console.ReadLine());
       Console.WriteLine(" Do you have vaild national ID (yes/no)");
       String nationalID = Console.ReadLine();

       bool validID = nationalID == "yes";

       if (age >= 18 && validID )
       {
        Console.WriteLine("eligible to vote");
       }
       else 
       {
        Console.WriteLine("Not eligible to vote");
       }*/
       
       // Task 5:Grade Letter Lookup
       /*Console.WriteLine("Enter a grade:");
       char grade = char.Parse(Console.ReadLine());

       switch (grade)
       {
        case 'A':
         Console.WriteLine("Excellent");
           break;
        case 'B':
         Console.WriteLine("VeryGood");
           break;
        case 'C':
         Console.WriteLine("Good");
         break;
        case 'D':
         Console.WriteLine("pass");
         break;
        case 'F':
         Console.WriteLine("Fail");
           break;
        default:
         Console.WriteLine("invalid grade");
           break;
       }*/
        // Task 6:Temperature Converter
        Console.WriteLine("Enter Temp in Celsius:");
        float C = float.Parse(Console.ReadLine());
        
        float F = C * 9 / 5 + 32;

        if (C < 10)
        {
         Console.WriteLine("Cold");
        }
        else if (C <=30)
        {
         Console.WriteLine("Mild");
        }
        else 
        {
         Console.WriteLine("Hot");
        }
        Console.WriteLine("Weather in Fahrenheit is:" +F);









    }
  
}