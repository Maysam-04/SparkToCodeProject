using System;
using System.Collections.Generic;

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
        ////////////////////////////////////////////////////////
        
        // Task 2 - Dynamic To-Do List
       List <string> task = new List <string> ();
        int counter;
        for (counter = 0; counter <5; counter++)
        {
            Console.WriteLine("enter the task:");
            task.Add(Console.ReadLine());
        }

        foreach (string taskitem in task)
        {
            Console.WriteLine(taskitem);
        }
       ////////////////////////////////////////////////
       
       //Task 3 - Browsing History Stack
       
       Stack<string> browserhistory = new Stack<string>();
       int B;
       for (B = 0; B < 3; B++)
       {
           Console.WriteLine("Enter browser URL: ");
           browserhistory.Push (Console.ReadLine());
       }
       
       string Result= browserhistory.Pop();
       
       Console.WriteLine("simulate to press back " + Result);


    }
}