using System;
using System.Collections.Generic;
namespace Capstone_Project;

class Program
{
    //Service 1 - Add New Account
    
    static List<string> CustomerName = new List<string>();
    static List<int> NewAccountNum = new List<int>();
    static List<double> StartingBalance = new List<double>();
    public static void AddAccount()
    
    {
        Console.WriteLine("enter customer name:");
        string customerName = Console.ReadLine();

        Console.WriteLine("enter account num:");
        int accountNum = int.Parse(Console.ReadLine());

        if (NewAccountNum.Contains(accountNum))
        {
            Console.WriteLine("Error Accountnumber already exists");
            return;
        
        }

        Console.WriteLine("Enter initial deposit:");
        double deposit = double.Parse(Console.ReadLine());
        if (deposit < 0)
        {
            Console.WriteLine("deposit cannot be negative");
            return;
        }
        
        CustomerName.Add(customerName);
        NewAccountNum.Add(accountNum);
        StartingBalance.Add(deposit);
        
        Console.WriteLine("You succsessfully opened new account here are the details:");
        Console.WriteLine("Customer's Name:"+customerName);
        Console.WriteLine("Customer's AccountNum:"+accountNum );
        Console.WriteLine("StartingBalance:"+deposit);
    }
        static void Main(string[] args)
        {
            AddAccount();
            
        }
    }
