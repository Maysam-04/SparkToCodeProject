using System;

namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        //Task 1 - Fixed Grades Array
        int[] grades = new int[5];
        int length;
       for (length = 0; length < grades.Length ; length++)
       {
          Console.WriteLine("Students Grades:");
          grades[length]= int.Parse(Console.ReadLine());
       }

       foreach (int i in grades)
       {
           Console.WriteLine(i);
       }
    }
}