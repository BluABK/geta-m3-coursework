using System;

namespace Pure_Puzzles
{
    /**
     * <summary>
     * 2-1 Write a program that produces the following shape:
     *   ########
     *    ######
     *     ####
     *      ##
     *
     * Given the following limitations:
     * Only cw allowed is: Console.Write("#"), Console.Write(" ") and Console.WriteLine(...)
     * </summary>
     */
    class MyTask2_1
    {
        public void PrintShape(int symbolCount)
        {
            int rows = symbolCount / 2;
            int rowSymbolCount = symbolCount;
            int paddingCount = 0;

            // For each row.
            for (int i = 0; i < rows; i++)
            {
                int sidePaddingCount = (symbolCount - rowSymbolCount) / 2;

                // Pad lhs.
                PrintPadding(sidePaddingCount);

                // Print current line of symbols.
                for (int j = 0; j < rowSymbolCount; j++)
                {
                    Console.Write("#");
                }

                // Pad rhs.
                PrintPadding(sidePaddingCount);

                // Print newline.
                Console.WriteLine();

                // Decrement amount of symbols for next row by 2.
                rowSymbolCount -= 2;

                // Increment amount of whitespace padding for next row by 2.
                paddingCount += 2;

            }
        }

        public void PrintPadding(int paddingCount)
        {
            for (int i = 0; i < paddingCount; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
