using System;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();

            // Input string
            string original = "Trilok";

            // Call (hit) the ReverseString method
            string reversed = p.ReverseString(original);

            // Display result
            Console.WriteLine("Original String: " + original);
            Console.WriteLine("Reversed String: " + reversed);
        }

        // Reverse a string and return the result
        public string ReverseString(string inputstring)
        {
            string reverseString = "";

            for (int i = inputstring.Length - 1; i >= 0; i--)
            {
                reverseString += inputstring[i];
            }

            return reverseString;
        }
    }
}
