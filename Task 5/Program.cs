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
        Console.WriteLine("Enter 3 browser URL: ");
        browserhistory.Push (Console.ReadLine());
        browserhistory.Push (Console.ReadLine());
        browserhistory.Push (Console.ReadLine());
        
       string Result= browserhistory.Pop();
       
       Console.WriteLine("simulate to press back " + Result);

      /////////////////////////////////////////////////////////////
      
        // Task 4 - Customer Service Queue
        
        Queue<string> waitingline = new Queue<string>();
        
        Console.WriteLine("enter 3 customer names:");
         waitingline.Enqueue(Console.ReadLine());
         waitingline.Enqueue(Console.ReadLine());
         waitingline.Enqueue(Console.ReadLine());
         
      Console.WriteLine(waitingline.Dequeue());
      
       
       
    }
}