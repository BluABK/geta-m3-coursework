using System;

namespace What_this_code_do
{
    class Program
    {
        static void Main()
        {
            // Define counts range to most of ASCII table, except the final 5 symbols.
            var range = 250;
            // Define an int array counts of size range.
            var counts = new int[range];
            // Define text string and assign it a default value.
            string text = "something";
            // Keep track of total amount of characters (used for %).
            int charTotal = 0;

            // While input text is not NULL or blank:
            while (!string.IsNullOrWhiteSpace(text))
            {
                // Read input.
                text = Console.ReadLine();

                // For each character in input (that is non-empty):
                foreach (var character in text.ToLower() ?? string.Empty)
                {
                    // Cast lower cased char in string to int, resulting in its ASCII value.
                    counts[(int)character]++;

                    // Increment total char count (used for %).
                    charTotal++;
                }

                // Loop over range:
                for (var i = 0; i < range; i++)
                {
                    // If item in array counts at index i has entry.
                    if (counts[i] > 0)
                    {
                        // Cast the index value as ASCII to char.
                        var character = (char)i;

                        // Calculate percentage.
                        double charCountPercentage = 100 * (double)counts[i] / charTotal;

                        // Print character and amount to screen.
                        Console.WriteLine($"{character} - {charCountPercentage:F2}%");
                    }
                }
            }
        }
    }
}
