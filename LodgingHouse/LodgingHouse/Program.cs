namespace LodgingHouse {
    class Program {
        static void Main(string[] args) {
            int rooms, roomNum; Rent[] rent = new Rent[10];


            do {
                Console.Write("How many rooms will be rented? ");
                rooms = int.Parse(Console.ReadLine());
                if(rooms <= 0) {
                    Console.WriteLine("Please enter how many rentals you want.");
                }
                if(rooms > 10) {
                    Console.WriteLine("The number of rentals exceeds the number of rooms");                   
                }
            } while(rooms <= 0 || rooms > 10);            

            for(int i = 1; i <= rooms; i++) {
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();            
                do {
                    Console.Write("Room: ");
                    roomNum = int.Parse(Console.ReadLine());
                    if(roomNum < 0 || roomNum > 9) {
                        Console.WriteLine("Invalid room");
                    }                    
                } while(roomNum < 0 || roomNum > 9);

                rent[roomNum] = new Rent(name, email);               
            }

            Console.WriteLine("\nOccupied Rooms:");
            for(int i = 0;i < 10;i++) {
                if(rent[i] != null) {
                    Console.WriteLine($"Room {i}: {rent[i]}");
                }
            }
        }
    }
}