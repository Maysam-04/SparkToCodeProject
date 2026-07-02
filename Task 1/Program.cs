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
  /*Console.WriteLine("Enter Temp in Celsius:");
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
  Console.WriteLine("Weather in Fahrenheit is:" +F);*/

  // Task 7:Movie Ticket Pricing
  /* Console.WriteLine("Enter your age:");
   int age = int.Parse(Console.ReadLine());
   if (age <= 12)
   {
    Console.WriteLine("ForChlidren Catogery the price is : 2 OMR ");
   }
   else if (age <=59)
   {
    Console.WriteLine("For Adult Catogery the price is : 5 OMR ");

   }
   else
   {
    Console.WriteLine("For Senior Catogery the price is : 3 OMR ");

   }*/

  //Task8:Restaurant Bill with Membership Discount
  /* Console.WriteLine("Enter the total bill :");
   float bill = float.Parse(Console.ReadLine());

   Console.WriteLine("Are you from the loyalty member (yes/no) :");
   String loyalty = Console.ReadLine();

   bool isloyalty = loyalty == "yes";

   float discount = 0;
   if (bill >20 &&  isloyalty)
   {
    discount = bill * 15 / 100;
   }
   else
   {
    Console.WriteLine(" no discount");
   }

    float finalbill = bill - discount;

   Console.WriteLine("The original bill is:" +bill);
   Console.WriteLine("The discount is: "+discount);
   Console.WriteLine("The final bill is:"+finalbill);*/

  // Task 9:Day Name Finder
  /*Console.WriteLine("Enter a number :");
  int week = int.Parse(Console.ReadLine());

  switch (week)
  {
   case 1:
    Console.WriteLine("Sunday");
    break;
   case 2:
    Console.WriteLine("Monday");
    break;
   case 3:
    Console.WriteLine("Tuesday");
    break;
   case 4:
    Console.WriteLine("Wednesday");
    break;
   case 5:
    Console.WriteLine("Thursday");
    break;
   case 6:
    Console.WriteLine("Friday");
    break;
   case 7:
    Console.WriteLine("Saturday ");
    break;
   default:
    Console.WriteLine("invalid Day number");
    break;
  }*/

  //Task 10:Mini Calculator
  Console.WriteLine("Enter first number:");
  int numberA = int.Parse(Console.ReadLine());
  Console.WriteLine("Enter second number:");
  int numberB = int.Parse(Console.ReadLine());
  
  Console.WriteLine("Enter the operation:");
  char Operator = char.Parse(Console.ReadLine());

  switch (Operator)
  {
   case '+':
    Console.WriteLine("The answer is:"+((numberA + numberB)));
    break;
   case '-':
    Console.WriteLine("The answer is:" + ((numberA - numberB)));
    break;
   case '*':
    Console.WriteLine("The answer is:"+((numberA * numberB)));
    break;
   case '/':
    if (numberB != 0)
    {
     Console.WriteLine("The answer is:"+((numberA / numberB)));
    }
    else
    {
     Console.WriteLine("Cannot divide by zero");
    }
    break;
   case '%':
    if (numberB != 0)
    {
     Console.WriteLine("The answer is:"+((numberA % numberB)));
    }
    else
    {
     Console.WriteLine("Cannot divide by zero");
    }
    break;
   
   default:
    Console.WriteLine("invalid operato");
    break;
  }
  

 }

}



