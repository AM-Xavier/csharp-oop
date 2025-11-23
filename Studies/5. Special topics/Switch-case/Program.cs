namespace Switch_case {
    internal class Program {
        static void Main(string[] args) {
            // Switch-case is an alternative to if-else statements for control flow based on the value of a variable.
            // Instead of using multiple if-else statements, you can use a switch-case to handle different cases more cleanly.

            int x = int.Parse(Console.ReadLine());
            string day;

            switch (x) {
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                case 7:
                    day = "Sunday";
                    break;
                default:
                    day = "Invalid day";
                    break;
            }
        }
    }
}
