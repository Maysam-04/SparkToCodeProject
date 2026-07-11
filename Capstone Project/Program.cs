using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Capstone_Project;

class Program
{
    //Service 1 - Add New Account

   static List<string> CustomerName = new List<string>();
    static List<int> NewAccountNum = new List<int>();
    static List<double> StartingBalance = new List<double>();

    static void AddAccount()

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
        Console.WriteLine("Customer's Name:" + customerName);
        Console.WriteLine("Customer's AccountNum:" + accountNum);
        Console.WriteLine("StartingBalance:" + deposit);
    }

    /////////////////////////////////////////////////////////////////////

    //Service 2 - Deposit Money

    static void DepositMoney()
    {
        Console.WriteLine("Enter the accnumber:");
        int accNumber = int.Parse(Console.ReadLine());

        int[] SearchAccNum = new int[] { accNumber };

        int index = SearchAccNum.IndexOf(accNumber);

        if (index == -1)
        {
            Console.WriteLine("You entered an invalid accnumber.");
            return;
        }

        Console.WriteLine("Enter the deposit amount: :");
        double depositAmount = double.Parse(Console.ReadLine());

        if (depositAmount < 0)
        {
            Console.WriteLine("You entered a negative deposit.");
            return;
        }

        StartingBalance[index] +=depositAmount;
        Console.WriteLine(" The updated balance:" + StartingBalance[index]);
    }

    /// //////////////////////////////////////////////////////////////////

    //Service 3 - Withdraw Money
    static void WithdrawMoney()
    {
        Console.WriteLine("Enter the accnumber:");
        int accountnumber = int.Parse(Console.ReadLine());
        
        int[]searchingforaccountnum=new []{accountnumber};
        int index = searchingforaccountnum.IndexOf(accountnumber);
        if (index == -1)
        {
            Console.WriteLine("You entered an invalid accnumber.");
            return;
        }
        Console.WriteLine("Enter the withdrawl amount:");
        double withdrawlAmount = double.Parse(Console.ReadLine());
        if (withdrawlAmount < 0)
        {
            Console.WriteLine("You entered a negative withdrawl amount.");
            return;
        }

        if (StartingBalance[index] < withdrawlAmount)
        {
            Console.WriteLine("You entered a different withdrawl amount.");
            return;
        }
        StartingBalance[index] -= withdrawlAmount;
        Console.WriteLine(" The updated balance:" + StartingBalance[index]);
    }

    /// /////////////////////////////////////////////////////////////

    // Service 4 - Show Balance
    static void ShowBalance()
    {
        Console.WriteLine("Enter the acccountnumber:");
        int acnumb = int.Parse(Console.ReadLine());
        
        int[]lookingforACCNUMB = new int[]{acnumb};
        int index = lookingforACCNUMB.IndexOf(acnumb);
        if (index == -1)
        {
            Console.WriteLine("You entered an invalid accnumber.");
            return;
        }
        Console.WriteLine("Customer name:" + CustomerName[index]);
        Console.WriteLine("Customer's AccountNum:" + NewAccountNum[index]);
        Console.WriteLine("Balance:" + StartingBalance[index]);
    }
    /// /////////////////////////////////////////////////////
    
    //
    

    static void Main(string[] args)
    {
        AddAccount();
        DepositMoney();
        WithdrawMoney();
        ShowBalance();

    }
}




    
