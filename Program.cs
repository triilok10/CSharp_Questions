using System;

namespace csharp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Program p = new Program();



            string original = "Trilok";

            string vowels = "aeiouAEIOUqwqw"; 
            p.CountVowets(vowels);

            // Call (hit) the ReverseString method
            string reversed = p.ReverseString(original);

            // Display result
            Console.WriteLine("Original String: " + original);
            Console.WriteLine("Reversed String: " + reversed);
            Console.WriteLine("Total count of the Vowels: " + vowels);
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

        // Count Vowers in the String
        public int CountVowets(string inputstring)
        {
            int count = 0;

            for (int i=0; i< inputstring.Length; i++)
            {
                char c = inputstring[i];
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                    c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                {
                    count++;
                }
            }
            return count;
        }
    }
}
