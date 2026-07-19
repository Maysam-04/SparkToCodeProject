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
    public string GuestId { get; set; }
    public string GuestName { get; set; }
    public string GuestRoomNumber { get; set; }
    public string CheckInDate  { get; set; }
    public int TotalNights { get; set; }

    public Guest(string guestId, string guestName, string guestRoomNumber, string checkInDate, int totalNights)
    {
        GuestId = guestId;
        GuestName = guestName;
        GuestRoomNumber = guestRoomNumber;
        CheckInDate= checkInDate;
        TotalNights = totalNights;
    }
    public void DisplayGuest()
    {
        Console.WriteLine("GuestId :" +GuestId);
        Console.WriteLine("Guest Name :" +GuestName);
        Console.WriteLine("Guest RoomNumber :" +GuestRoomNumber);
        Console.WriteLine("Guest Check In Date :"  +CheckInDate);
        Console.WriteLine("Guest TotalNights :"  +TotalNights);
    }

    public double calculateTotalCost(double PricePerNight)
    {
        return PricePerNight * TotalNights;
    }
    
    
}

public class Program
{
    static List<Room> rooms = new List<Room>();
    static List<Guest> guests = new List<Guest>();

    static void Main(string[] args)
    {
        Room R1 = new Room(1001, "Single", 20.5, true);
        rooms.Add(R1);
        Room R2 = new Room(1002, "Single", 20.5, true);
        rooms.Add(R2);
        Room R3 = new Room(1003, "Double", 50, false);
        rooms.Add(R3);
        Room R4 = new Room(1004, "Double", 50, false);
        rooms.Add(R4);
        Room R5 = new Room(1005, "Suite", 70, true);
        rooms.Add(R5);
        Room R6 = new Room(1006, "Suite", 70, true);
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
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookaRoomforaGuest(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: SearchandFilterRooms(); break;
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

        //Case 01 Add New Room
        static void AddNewRoom()
        {
            Console.WriteLine("Enter the room number:");
            int RoomNumber = int.Parse(Console.ReadLine());
            if (rooms.Any(r => r.RoomNumber == RoomNumber))
            {
                Console.WriteLine("Room Number already exists!");
                return;
            }

            Console.WriteLine("Enter the room type (Single / Double / Suite):");
            string RoomType = Console.ReadLine();

            Console.WriteLine("Enter the price per Night:");
            double PricePerNight = double.Parse(Console.ReadLine());
            if (PricePerNight <= 0)
            {
                Console.WriteLine("Price per Night must be a positive number.");
                return;
            }

            Room Room = new Room(RoomNumber, RoomType, PricePerNight, true);
            rooms.Add(Room);

            Console.WriteLine("Room Added Successfully!");
            Console.WriteLine("Room Number :" + Room.RoomNumber);
            Console.WriteLine("Room Type :" + Room.RoomType);
            Console.WriteLine("Room Price per Night :" + Room.PricePerNight);
            Console.WriteLine("Availabilty" + Room.IsAvailable);
            Console.WriteLine("The Total" + rooms.Count);
        }

        //Case 02 Register New Guest

        static void RegisterNewGuest()
        {
            Console.WriteLine("Enter the guest name:");
            string guestName = Console.ReadLine();

            Console.WriteLine("Enter check-in date:");
            string CheckInDate = Console.ReadLine();

            Console.WriteLine("Enter number of nights to stay:");
            int numberofnights = int.Parse(Console.ReadLine());
            if (numberofnights <= 0)
            {
                Console.WriteLine("Number of nights must be a positive number.");
                return;
            }

            string guestId = "G" + (guests.Count + 1).ToString("D3");
            Guest guest = new Guest(guestId, guestName, "Not Assigned", CheckInDate, numberofnights);
            guests.Add(guest);
        }
        
        //Case 03 Book a Room for a Guest

        static void BookaRoomforaGuest()
        {
            Console.WriteLine("Enter the guest Id:");
            string guestId = Console.ReadLine();
            
            Console.WriteLine("Enter the roomnumber:");
            int RoomNumber = int.Parse(Console.ReadLine());
            
            Guest guest= guests.FirstOrDefault(g=>g.GuestId==guestId);
            if (guest == null)
            {
                Console.WriteLine("Guest not found!");
                return;
            }
            Room room= rooms.FirstOrDefault(r => r.RoomNumber == RoomNumber);
            if (room == null)
            {
                Console.WriteLine("Room not found!");
                return;
            }

            if (room.IsAvailable == true)
            {
                Console.WriteLine("Room is already booked!");
                return;
            }
            guest.GuestRoomNumber = room.RoomNumber.ToString();
            room.IsAvailable = false;
            double TotalCost = guest.calculateTotalCost(room.PricePerNight);
            
            
            Console.WriteLine("Booking was successfully done");
            Console.WriteLine("Guest name:" + guest.GuestName);
            Console.WriteLine("Room Number :" + room.RoomNumber);
            Console.WriteLine("Room Type :" + room.RoomType);
            Console.WriteLine("Room Price per Night :" + room.PricePerNight);
            Console.WriteLine("Total nights:" + guest.TotalNights);
            Console.WriteLine("Total Cost:" + TotalCost);
        }
        
        //Case 04 View All Rooms

        static void ViewAllRooms()
        {
            if (rooms.Count() == 0)
            {
                Console.WriteLine("No rooms have been added yet!");
                return;
            }

            Console.WriteLine("Total room:" + rooms.Count());
            Console.WriteLine();

            var roomslist = rooms.OrderBy(r => r.RoomNumber)
                .Select(r => new
                {
                    r.RoomNumber,
                    r.RoomType,
                    r.PricePerNight,
                    Status = r.IsAvailable ? "Available" : "Booked"
                });
            foreach (var room in roomslist)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("Room number:" + room.RoomNumber);
                Console.WriteLine("Room type:" + room.RoomType);
                Console.WriteLine("price per night:" + room.PricePerNight);
                Console.WriteLine("status:" + room.Status);
            }
        }

        //Case 05 View All Guests
        static void ViewAllGuests()
        {
            if (guests.Count() == 0)
            {
                Console.WriteLine("No guests have been registered yet");
                return;
            }

            Console.WriteLine("Total guests:" + guests.Count());
            var guestlist = guests.OrderBy(g => g.GuestName).Select(g => new
            {
                g.GuestId,
                g.GuestName,
                g.GuestRoomNumber,
                g.CheckInDate,
                g.TotalNights
            });
            foreach (var guest in guestlist)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("GuestId:" + guest.GuestId);
                Console.WriteLine("GuestName:" + guest.GuestName);
                Console.WriteLine("GuestRoomNumber:" + guest.GuestRoomNumber);
                Console.WriteLine("CheckInDate:" + guest.CheckInDate);
                Console.WriteLine("Total nights:" + guest.TotalNights);
            }
        }

                 //Case 06 Search & Filter Rooms
                 static void SearchandFilterRooms()
                 {
                     int choice;
                     do
                     {
                         Console.WriteLine("********** Room Search ********** ");
                         Console.WriteLine("1.Show all available rooms");
                         Console.WriteLine("2.Filter by room type");
                         Console.WriteLine("3.Filter by max price");
                         Console.WriteLine("4.Room price statistics");
                         Console.WriteLine("0 Back ");
                         Console.WriteLine("Enter your choice:");

                         choice = int.Parse(Console.ReadLine());

                         switch (choice)
                         {
                             case 1:
                                 var AvailableRooms = rooms.Where(r => r.IsAvailable)
                                     .OrderBy(r => r.PricePerNight)
                                     .Select(r => new
                                     {
                                         r.RoomNumber,
                                         r.RoomType,
                                         r.PricePerNight,
                                     });
                                 if (AvailableRooms.Count() == 0)
                                 {
                                     Console.WriteLine("No rooms found for the selected criteria");

                                 }
                                 else
                                 {
                                     Console.WriteLine("Available rooms:" + AvailableRooms.Count());

                                     foreach (var room in AvailableRooms)
                                     {
                                         Console.WriteLine("-------------------");
                                         Console.WriteLine("Room Number:" + room.RoomNumber);
                                         Console.WriteLine("Room Type:" + room.RoomType);
                                         Console.WriteLine("Room Price:" + room.PricePerNight);
                                     }
                                 }

                                 break;
                             case 2:
                                 Console.WriteLine("Enter the Room Type (single/double/suite):");
                                 string type = Console.ReadLine();

                                 var roomtype = rooms.Where(r => r.RoomType == type)
                                     .OrderBy(r => r.RoomNumber)
                                     .Select(r => new
                                     {
                                         r.RoomNumber,
                                         r.RoomType,
                                         r.PricePerNight,
                                         status = r.IsAvailable ? "Available" : "Booked"
                                     });
                                 if (roomtype.Count() == 0)
                                 {
                                     Console.WriteLine("No rooms found for the selected criteria.");
                                 }
                                 else
                                 {
                                     Console.WriteLine("Available rooms:" + roomtype.Count());

                                     foreach (var room in roomtype)
                                     {
                                         Console.WriteLine("Room Number:" + room.RoomNumber);
                                         Console.WriteLine("RoomType:" + room.RoomType);
                                         Console.WriteLine("Room Price:" + room.PricePerNight);
                                         Console.WriteLine("status:" + room.status);
                                     }
                                 }

                                 break;
                             case 3:
                                 Console.WriteLine("Enter max price:");
                                 double maxprice = double.Parse(Console.ReadLine());

                                 var downgraderooms = rooms.Where(r => r.PricePerNight > maxprice)
                                     .OrderBy(r => r.PricePerNight)
                                     .Select(r => new
                                     {
                                         r.RoomNumber,
                                         r.RoomType,
                                         r.PricePerNight
                                     });
                                 if (downgraderooms.Count() == 0)
                                 {
                                     Console.WriteLine("No rooms found for the selected criteria");
                                 }
                                 else
                                 {
                                     Console.WriteLine("Available rooms:" + downgraderooms.Count());

                                     foreach (var room in downgraderooms)
                                     {
                                         Console.WriteLine("Room Number:" + room.RoomNumber);
                                         Console.WriteLine("RoomType:" + room.RoomType);
                                         Console.WriteLine("Room Price:" + room.PricePerNight);
                                     }
                                 }

                                 break;

                             case 4:
                                 if (rooms.Count() == 0)
                                 {
                                     Console.WriteLine("No rooms founded.");
                                 }
                                 else
                                 {
                                     Console.WriteLine("---------- Room Analytics----------");
                                     Console.WriteLine("totalRoom:" + rooms.Count());
                                     Console.WriteLine("Available Rooms:" + rooms.Count(r => r.IsAvailable));
                                     Console.WriteLine("Average Price:" + rooms.Average(r => r.PricePerNight));
                                     Console.WriteLine("Cheapest Price:" + rooms.Min(r => r.PricePerNight));
                                     Console.WriteLine("Most Expensive Price " + rooms.Max(r => r.PricePerNight));

                                 }

                                 break;
                             case 0:
                                 Console.WriteLine("Go back to the Menu");
                                 break;
                             default:
                                 Console.WriteLine("Invalid choice");
                                 break;
                         }

                     } while (choice != 0);
                 }
        }
    }


