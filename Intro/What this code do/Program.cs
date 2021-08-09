using System;

namespace What_this_code_do
{
    /**
     * GET Academy C# Intro Puzzle: "What does this code do?".
     *
     * A: It's a character counter. It counts the occurence of characters that are
     *    ASCII 0-249 and prints a list of counts (edit: now percentage, after task 4).
     */
    class Program
    {
        static void Main()
        {
            // Define counts Range to most of ASCII table, except the final 5 symbols.
            const int Range = 250;
            // Define an int array counts of size Range.
            int[] counts = new int[Range];
            // Define text string and assign it a default value.
            string text = "something";
            // Keep track of total amount of characters (used for %).
            int charTotal = 0;
            // Right align field width to the spacing of 8 chars (Max: "100.00 %").
            const int FieldWidthRightAligned = 8;

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

                // Loop over Range:
                for (int i = 0; i < Range; i++)
                {
                    // If item in array counts at index i has entry.
                    if (counts[i] > 0)
                    {
                        // Cast the index value as ASCII to char.
                        char character = (char)i;

                        // Calculate percentage.
                        double charCountPercentage = 100 * (double)counts[i] / charTotal;

                        // Print character and amount to screen, on the form "[X|XX|XXX].XX %".
                        Console.WriteLine($"{character} - {charCountPercentage,FieldWidthRightAligned:F2} %");
                    }
                }
            }
        }
    }
}
