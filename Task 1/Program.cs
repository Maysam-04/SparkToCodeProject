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
      Console.WriteLine("Enter a num:"); 
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
      }
       
       
       
       
       



    }
  
}