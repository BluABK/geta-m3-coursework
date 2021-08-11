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
        public void Run()
        {
            int symbolCount = 8;
            int rows = symbolCount / 2;
            int rowSymbolCount = symbolCount;
            int paddingCount = 0;

            // For each row.
            for (int i = 0; i < rows; i++)
            {
                // Pad lhs.
                printPadding( (symbolCount - rowSymbolCount) / 2 );

                // Print current line of symbols.
                for (int j = 0; j < rowSymbolCount; j++)
                {
                    Console.Write("#");
                }

                // Pad rhs.
                printPadding((symbolCount - rowSymbolCount) / 2);

                Console.WriteLine();

                rowSymbolCount -= 2;
                paddingCount += 2;

            }
        }

        public void printPadding(int paddingCount)
        {
            for (int i = 0; i < paddingCount; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
