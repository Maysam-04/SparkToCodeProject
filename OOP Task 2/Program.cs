namespace OOP_Task_2;

public class Room
{
    public int RoomNumber { get; set; }
    public string RoomType { get; set; }
    public double PricePerNight { get; set; }
    public bool IsAvailable { get; set; }


    public void DisplayRoom()
    {
        Console.WriteLine("Room Number:" + RoomNumber);
        Console.WriteLine("Room Type:" + RoomType);
        Console.WriteLine("Room Price per Night:" + PricePerNight);
        Console.WriteLine("Available :" + IsAvailable);
    }

    public Room(int roomNumber, string roomType, double pricePerNight, bool isAvailable)
    {
        RoomNumber = roomNumber;
        RoomType = roomType;
        PricePerNight = pricePerNight;
        IsAvailable = isAvailable;
    }
}




public class Guest
{
    public int GuestId { get; set; }
    public string GuestName { get; set; }
    public int GuestRoomNumber { get; set; }
    public DateTime CheckInDate  { get; set; }
    public int TotalNights { get; set; }

    public void DisplayGuest()
    {
        Console.WriteLine("GuestId :" +GuestId);
        Console.WriteLine("Guest Name :" +GuestName);
        Console.WriteLine("Guest RoomNumber :" +GuestRoomNumber);
        Console.WriteLine("Guest Check In Date :"  +CheckInDate);
        Console.WriteLine("Guest TotalNights :"  +TotalNights);
    }

    public double calculateTotalCost(double pricePerNight)
    {
        return pricePerNight *= TotalNights;
    }
    
    
}

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();
        List<Guest> guests = new List<Guest>();
        
        Room R1 = new Room(1001,"Single", 20.5, true);
        rooms.Add(R1);
        Room R2 = new Room(1002,"Single", 20.5, true);
        rooms.Add(R2);
        Room R3 = new Room(1003,"Double", 50, false);
        rooms.Add(R3);
        Room R4 = new Room(1004,"Double", 50, false);
        rooms.Add(R4);
        Room R5 = new Room(1005,"Suite", 70, true);
        rooms.Add(R5);
        Room R6 = new Room(1006,"Suite", 70, true);
        rooms.Add(R6);
        {
        bool Menu = false;

        while (Menu == false)
        {
            Console.WriteLine("\n======= GRAND VISTA HOTEL — MANAGEMENT SYSTEM ========");
            Console.WriteLine(" 1.Add New Room");
            Console.WriteLine(" 2.Register New Guest");
            Console.WriteLine(" 3.Book a Room for a Guest ");
            Console.WriteLine(" 4.View All Rooms ");
            Console.WriteLine(" 5.View All Guests ");
            Console.WriteLine(" 6.Search & Filter Rooms ");
            Console.WriteLine(" 7.Guest & Booking Statistics ");
            Console.WriteLine(" 8. Update Room Price ");
            Console.WriteLine("16. Exit");
            Console.Write("Choose an option: ");
            int choice;
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 16.");
                continue;
            }

            switch (choice)
            {
                
                case 1:AddNewRoom();break;
                case 2:RegisterNewGuest();break;                       
                case 3:BookaRoomforaGuest();break;                  
                case 4:ViewAllRooms();break;                  
                case 5:ViewAllGuests();break;              
                case 6:Search&FilterRooms();break;                         
                case 7:Guest&Booking Statistics();break;                       
                case 8:UpdateRoomPrice();break;
                case 16:
                    Menu = true;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please choose between 1 and 16.");
                    break;
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
            Console.Clear();
        }
    }
    }
    
}
