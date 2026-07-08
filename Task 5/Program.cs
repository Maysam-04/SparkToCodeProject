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
      
       ////////////////////////////////////////////////////////////
       
       // Task 5 - Array Grade Range
       int[] Grades=new int[5];
       int G;
       for (G = 0; G < Grades.Length; G++)
       {
           Console.WriteLine(" Enter Grades");
           Grades[G] = int.Parse(Console.ReadLine());
       }
       Array.Sort(Grades);
       int lowest = Grades[0];
       int highest= Grades[Grades.Length-1];

       int total = 0;

       for (int i = 0; i < Grades.Length; i++)
       {
           total += Grades[i];
       }
       
       float average = total / Grades.Length;
       
       Console.WriteLine("The total result:"+total);
       Console.WriteLine("The highest result:"+highest);
       Console.WriteLine("The Average result:"+average);

    }
}