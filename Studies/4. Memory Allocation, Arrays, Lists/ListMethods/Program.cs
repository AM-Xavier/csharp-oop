using System.Collections.Generic;

namespace ListMethods {
    internal class Program {
        static void Main(string[] args) {

            // Lists have some certain types of methods
            List<string> list = new List<string>();

            // Add: Used to add items to the end of a list
            list.Add("Mary");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Robert");
            list.Add("Alicia");

            // Insert: Used to insert an item into a specific position in a list
            list.Insert(2, "Mark");
            foreach(string name in list) {
                Console.WriteLine(name);
            }

            // Count: Used to count the amount of items in a list
            Console.WriteLine("List count: " + list.Count);

            // Find: Used to find an item/items in a list using a function.
            // There's five types, two to find items: Find, FindLast. Two to find indexes: FindIndex, FindLastIndex. And one to filter lists: FindAll.
            // The Find method can use functions or lambda expressions.

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First A: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last A: " + s2);

            int i1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Last A: " + i1);

            int i2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Last A: " + i2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("-----------------------");
            foreach(string name in list2) {
                Console.WriteLine(name);
            }

            // Remove: Used to remove items from a list.
            // There's four types: Remove, RemoveAt, RemoveAll, RemoveRange.
            // RemoveAt: Used to remove a specific position.
            // RemoveRange: Used to remove a specific range and amount of items in that range. 

            list.Remove("Alex");
            Console.WriteLine("-----------------------");
            foreach (string name in list) {
                Console.WriteLine(name);
            }

            list.RemoveAt(3);
            Console.WriteLine("-----------------------");
            foreach(string name in list) {
                Console.WriteLine(name);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("-----------------------");
            foreach(string name in list) {
                Console.WriteLine(name);
            }

            list.RemoveRange(2, 2);
            Console.WriteLine("-----------------------");
            foreach(string name in list) {
                Console.WriteLine(name);
            }

        }
    }
}
