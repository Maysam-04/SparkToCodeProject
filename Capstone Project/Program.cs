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

    //Service 5 - Transfer Amount
    static void TransferAmount()
    {
        Console.WriteLine("Enter the sender's account number: ");
        int senderAccountNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the receiver's account number: ");
        int receiverAccountNum = int.Parse(Console.ReadLine());
        
        int[] findingoutsenderaccountnumber=new []{senderAccountNum};
        
        int senderindex= findingoutsenderaccountnumber.IndexOf(senderAccountNum);
        if (senderindex == -1)
        {
            Console.WriteLine("You entered an invalid sender account number.");
            return;
        }
        
        int[] findingoutreceiveraccountnumber=new []{receiverAccountNum};
        
        int receiverindex =findingoutreceiveraccountnumber.IndexOf(receiverAccountNum);
        if (receiverindex == -1)
        {
            Console.WriteLine("You entered an invalid receiver account number.");
            return;
        }
        Console.WriteLine("Enter the transfer amount:");
        double transferAmount = double.Parse(Console.ReadLine());
        if (transferAmount > StartingBalance[senderindex])
        {
            Console.WriteLine("sender has sufficient balance");
            return;
        }
        StartingBalance[senderindex] -= transferAmount;
        StartingBalance[receiverindex] -= transferAmount;
        
        Console.WriteLine("Transfer successfully completed") ;
        Console.WriteLine("Sender's updated Balance:" + StartingBalance[senderindex] );
        Console.WriteLine("Receiver's updated Balance:" + StartingBalance[receiverindex] );
       
    }
    
    /////////////////////////////////////////////
    
    // Service 6- Listing All Accounts
    static void ListAllAccounts()
    {
        if (CustomerName.Count == 0)
        {
            Console.WriteLine("There are no customers account in the list.");
            return;
        }

        Console.WriteLine("\n =========== ALL CUSTOMER ACCOUNT LIST==========");

        int A;
        for ( A=0; A < CustomerName.Count; A++)
        {
            Console.WriteLine("Customer Name:"+CustomerName[A]);
            Console.WriteLine("Account Number"+NewAccountNum[A]);
            Console.WriteLine("Balance:"+StartingBalance[A]);
        }

    }

    /// ///////////////////////////////////////////////////////////

    //Service 7- Searching by Customer Name
    static void SearchingCustomersNames()
    {
        Console.WriteLine("enter your name: ");
        string name = Console.ReadLine();

        int C = 0;
        for (C = 0; C < CustomerName.Count; C++)
        {
            if (CustomerName[C] == name)
            {
                Console.WriteLine("Customer Name:" + CustomerName[C]);
                Console.WriteLine("Account Number:" + NewAccountNum[C]);
                Console.WriteLine("Balance:" + StartingBalance[C]);
            }
            else if (CustomerName[C] != name)
            {
                Console.WriteLine("Customer Name is not found");
            }
        }
    }
    
    

    static void Main(string[] args)
    {
        AddAccount();
        DepositMoney();
        WithdrawMoney();
        ShowBalance();
        TransferAmount();
        ListAllAccounts();
        SearchingCustomersNames();

    }
}




    
