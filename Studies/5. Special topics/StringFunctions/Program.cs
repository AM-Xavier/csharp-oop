namespace StringFunctions {
    internal class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG ";

            string s1 = original.ToUpper(); // Converts all characters in the string to uppercase
            string s2 = original.ToLower(); // Converts all characters in the string to lowercase
            string s3 = original.Trim(); // Removes leading and trailing whitespace from the string
            int n1 = original.IndexOf("bc"); // Finds the index of the first occurrence of the substring "bc"
            int n2 = original.LastIndexOf("bc"); // Finds the index of the last occurrence of the substring "bc"
            string s4 = original.Substring(3); // Extracts a substring starting from index 3 to the end of the string
            string s5 = original.Substring(3, 5); // Extracts a substring starting from index 3 with a length of 5 characters
            string s6 = original.Replace('a', 'x'); // Replaces all occurrences of the character 'a' with 'x'
            string s7 = original.Replace("abc", "xy"); // Replaces all occurrences of the substring "abc" with "xy"
            bool b1 = String.IsNullOrEmpty(original); // Checks if the string is null or empty
            bool b2 = String.IsNullOrWhiteSpace(original); // Checks if the string is null, empty, or consists only of whitespace characters

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}
