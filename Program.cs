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
            int count = p.FionacciSeries(20);

            bool isLeap = p.IsLeapYear(2025);


            // For Swap of the Two variables
            int a = 12;
            int b = 4;

            p.swapVariable(ref a, ref b);

            // Display result
            Console.WriteLine("Original String: " + original);
            Console.WriteLine("Reversed String: " + reversed);
            Console.WriteLine("Total count of the Vowels: " + vowels);
            Console.WriteLine("Total Count of the Fiboconni: " + vowels);
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

            for (int i = 0; i < inputstring.Length; i++)
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

        // Fionacci Series
        public int FionacciSeries(int n)
        {
            int a = 0;
            int b = 1;
            int c = 0;
            Console.WriteLine("Fibonacci Series up to " + n + ":");
            Console.Write(a + " " + b + " ");
            for (int i = 0; i < n; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
            return c;
        }

        // Check Leap Year
        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    return (year % 400 == 0);
                }
                return true;
            }
            return false;
        }


        //Swap two variables without using the 3rd variables.

        public void swapVariable(ref int a,ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

    }
}
