using System;
using System.Runtime.InteropServices.JavaScript;

namespace OOP_Task_1;

public class BankAccount
{
 public int AccountNumber { get; set; }
 public string HolderName { get; set; }
 public double Balance { get; set; }
 public void Deposit(double amount)
 {
  Balance += amount;
  Console.WriteLine("your deposit has been deposited" + amount);
  SendEmail();
 }
 public void Withdraw(double amount)
 {
  if (Balance >= amount)
  {
   Balance -= amount;
   Console.WriteLine("your withdrawal is sufficent" + amount);
  }
  else
  {
   Console.WriteLine("your withdrawal is insufficent");
   return;
  }
  SendEmail();
 }
 public double CheckBalance()
 {
  PrintInformation();
  return Balance;
 }
 private void PrintInformation()
 {
  Console.WriteLine("Name: " + HolderName);
  Console.WriteLine("Balance: " + Balance);
 }
 private void SendEmail()
 {
  Console.WriteLine("Email notification being sent");
 }
  public BankAccount()
 {
 int AccountNumber = 0;
  string HolderName = "";
   double Balance = 0;
 }
}


public class Student
{
 public int Grade { get; set; }
 public string Name { get; set; }
 public string Address { get; set; }
 private string email { get; set; }
 private int age { get; set; }
 static int studentCount = 0;
 public Student()
 {
  studentCount++;
 }
 public void Register(string Email)
 {
  sendEmail();
  email = Email;
 }
 private void sendEmail()
 {
  Console.WriteLine("Registration being sent");
 }
 public static int GetStudentCount()
 {
  return studentCount;
 }
}


public class Product
  {
   public string ProductName { get; set; }
   public double Price { get; set; }
   public int StockQuantity { get; set; }
   public void sell(int quantity)
   {
    if (quantity <= StockQuantity)
    {
     StockQuantity -= quantity;
     Console.WriteLine(" stock  is: " + StockQuantity);
    }
    else
    {
     Console.WriteLine("not enough stock");
     LogTransaction();
    }
   }
   public void Restock(int quantity)
   {
    StockQuantity += quantity;
    Console.WriteLine(" stock  is: " + StockQuantity);
    LogTransaction();
   }
   public double GetInventoryValue()
   {
    PrintDetails();
    return Price * StockQuantity;
   }
   private void PrintDetails()
   {
    Console.WriteLine("Product name: " + ProductName);
    Console.WriteLine("Product price: " + Price);
    Console.WriteLine("Stock quantity: " + StockQuantity);
   }
   private void LogTransaction()
   {
    Console.WriteLine("Transaction is logged");
   }
  }


  public class Program
  {
   static BankAccount _account1 = new BankAccount { AccountNumber = 1163, HolderName = "Maysam", Balance = 120 };
   static BankAccount _account2 = new BankAccount { AccountNumber = 1567, HolderName = "Maysaa", Balance = 150 };

   static Student Student1 = new Student { Name = "Molham", Address = "Muscat", Grade = 99 };
   static Student Student2 = new Student { Name = "Adam", Address = "Nizwa", Grade = 98 };

   static Product Product1 = new Product { ProductName = "Wireless Mouse", Price = 5.500, StockQuantity = 50 };
   static Product Product2 = new Product { ProductName = "Keyboard", Price = 16.750, StockQuantity = 30 };



   static void Main(string[] args)
   {
    bool exitApp = false;

    while (exitApp == false)
    {
     Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
     Console.WriteLine(" 1. View Account Details");
     Console.WriteLine(" 2. Update Student Address");
     Console.WriteLine(" 3. Make a Deposit");
     Console.WriteLine(" 4. Make a Withdrawal");
     Console.WriteLine(" 5. View Product Details");
     Console.WriteLine(" 6. Register a Student");
     Console.WriteLine(" 7. Compare Two Account Balances");
     Console.WriteLine(" 8. Restock Product & Stock Level Check");
     Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
     Console.WriteLine("17. Total Students Counter (Static Field & Method)");
     Console.WriteLine("20. Exit");
     Console.Write("Choose an option: ");
     int choice;
     try
     {
      choice = int.Parse(Console.ReadLine());
     }
     catch (Exception)
     {
      Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
      continue;
     }

     switch (choice)
     {
      case 1: ViewAccountDetails(); break;
      case 2: UpdateStudentAddress(); break;
      case 3: MakeDeposit(); break;
      case 4: MakeWithdrawal(); break;
      case 5: ViewProductDetails(); break;
      case 6: RegisterStudent(); break;
      case 7: CompareAccountBalances(); break;
      case 8: RestockProduct(); break;
      case 16: QuickAccountBalance(); break;
      case 17: TotalStudentsCounter(); break;
      case 20:
       exitApp = true;
       Console.WriteLine("Goodbye!");
       break;
      default:
       Console.WriteLine("Invalid option, please choose between 1 and 20.");
       break;
     }
     Console.WriteLine("Press any key");
     Console.ReadKey();
     Console.Clear();
    }
   }

   static BankAccount ChooseAccount()
   {
    Console.WriteLine("Choose an account (1 or 2) ");
    string accountChoice = Console.ReadLine();
    if (accountChoice == "1")
    {
     return _account1;
    }

    return _account2;
   }

   static Student ChooseStudent()
   {
    Console.WriteLine("Choose a student (1 or 2) ");
    string studentChoice = Console.ReadLine();
    if (studentChoice == "1")
    {
     return Student1;

    }

    return Student2;
   }

   static Product ChooseProduct()
     {
      Console.WriteLine("Choose a product  (1 or 2) ");
      string productChoice = Console.ReadLine();
      if (productChoice == "1")
      {
       return Product1;
      }
      return Product2;
     }
     
     //Case 1 - View Account Details
     static void ViewAccountDetails()
     {
      BankAccount account = ChooseAccount();
      double balance = account.CheckBalance();
      Console.WriteLine("Your balance is: " + balance);
     }

     //Case 2 - Update Student Address
     static void UpdateStudentAddress()
     {
      Student student = ChooseStudent();
      Console.WriteLine("enter new address:");
      string newaddress = Console.ReadLine();
      student.Address= newaddress;
      Console.WriteLine("Address successfully updated:");
      Console.WriteLine("New address is: " + student.Address);
     }
     //Case 3 - Make a Deposit
     static void MakeDeposit()
     {
      BankAccount account = ChooseAccount();
      Console.WriteLine("Enter amount to deposit: ");
      string amount = Console.ReadLine();
      double deposit = double.Parse(amount);
      account.Deposit(deposit);
      Console.WriteLine("Holder's Name: " + account.HolderName);
      Console.WriteLine("Updated Balance: " + account.Balance);
     }
     
     //Case 4 - Make a Withdrawal
     
     static void MakeWithdrawal()
     {
      BankAccount account = ChooseAccount();
      Console.WriteLine("Enter amount to withdraw: ");
      string amount = Console.ReadLine();
      double withdrawal = double.Parse(amount);
      account.Withdraw(withdrawal);
      Console.WriteLine("Updated Balance : "  + account.Balance);
     }
     
     //Case 5 - View Product Details

     static void ViewProductDetails()
     {
      Product product = ChooseProduct();
      Console.WriteLine("ProductName: "+ product.ProductName);
      Console.WriteLine("Price: " + product.Price);
      Console.WriteLine("Stock Quantity: " + product.StockQuantity);
      double value = product.GetInventoryValue();
     }
     
     //Case 6 - Register a Student
     static void RegisterStudent()
     {
      Student student = ChooseStudent();
      Console.WriteLine("Enter email:");
      string email = Console.ReadLine();
      student.Register(email);
      Console.WriteLine("This email does not reveal anywhere");
     }
     
     //Case 7 - Compare Two Account Balances

     static void CompareAccountBalances()
     {
      double Balance1 = _account1.Balance;
      double Balance2 = _account2.Balance;
      if (Balance1 > Balance2)
      {
       Console.WriteLine("This accountholder holds more money:" + _account1.HolderName);
      }
      else if (Balance1 < Balance2)
      {
       Console.WriteLine("This accountholder holds more money:" + _account2.Balance);
      }
      else
      {
       Console.WriteLine("Both accounts holds the same amount ");
      }
     }

     //Case 8 - Restock Product & Stock Level Check

     static void RestockProduct()
     {
      Product product = ChooseProduct();
      Console.WriteLine(" enter the quantity restock ");
      int quantity = int.Parse(Console.ReadLine());

      product.Restock(quantity);
      int Stock = product.StockQuantity;
      if (Stock < 10)
      {
       Console.WriteLine("This product is low");
      }
      else if (Stock < 49)
      {
       Console.WriteLine("This product is Moderate");
      }
      else if (Stock > 50)
      {
       Console.WriteLine("This product is well stocked");
      }
     }
     //Case 16 - Quick Account Opening [Parameterized Constructor]

       static void QuickAccountBalance()
       {
        Console.WriteLine("Enter accountnumber: ");
        int Number = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter Holdername: ");
        string Name = Console.ReadLine();
        
        Console.WriteLine("Enter Balance: ");
        double balance = double.Parse(Console.ReadLine());
        
        BankAccount account = new BankAccount();
        
         account.AccountNumber = Number;
         account.HolderName = Name;
         account.Balance=balance;
       }
       
       
       //Case 17 - Total Students Counter [Static Fields & Methods]
      
      static void TotalStudentsCounter()
      {
       Console.WriteLine("the total of  created student are:"+Student.GetStudentCount());
      }

     }

    
   
  

  
  
 

 
 

