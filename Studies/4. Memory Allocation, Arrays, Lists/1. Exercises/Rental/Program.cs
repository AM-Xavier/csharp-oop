namespace Rental {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("How many rooms will be rented? ");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Rooms[] vect = new Rooms[9];

            for(int i = 0; i < r; i++) {
                int n = (i + 1);
                Console.WriteLine("Rent #" + n);

                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter student email: ");
                string email = Console.ReadLine();

                Console.Write("Enter room's number: ");
                int room = int.Parse(Console.ReadLine());

                Console.WriteLine();

                vect[i] = new Rooms { Name = name, Email = email, Room = room };
            }

            Console.WriteLine("Busy rooms:");

            for(int i = 0; i < r; i++) {
                if(vect[i] != null) {
                    Console.WriteLine(vect[i].Room + ": " + vect[i].Name + ", " + vect[i].Email);
                }
            }
        }
    }
}
