using System;

namespace Pure_Puzzles
{
    class CrossShape
    {
        /**
          * <summary>
          * Print the following shape:
          * #            #
          *  ##        ##
          *   ###    ###
          *    ########
          *    ########
          *   ###    ###
          *  ##        ##
          * #            # 
          * 
          * Given the following limitations:
          * Only cw allowed is: Console.Write("#"), Console.Write(" ") and Console.WriteLine(...)
          * </summary>
          */
        public void Print(int symbolCount)
        {
            int rows = symbolCount / 2;
            int rowSymbolCount;
            int paddingCount = symbolCount - 2;
            int innerPaddingCount;
            int singleOuterSidePaddingCount;
            int maxOuterSidePadding = rows - 1;

            // FIXME: Top part
            // For each row.
            for (int i = 0; i < rows; i++)
            {
            }

            // FIXME: Bottom part
            rowSymbolCount = symbolCount;
            // For each row.
            for (int i = 0; i < rows; i++)
            {
                singleOuterSidePaddingCount = maxOuterSidePadding - i;

                // If first row: 0, else: relative maths.
                innerPaddingCount = i == 0 ? 0 : i * 4;

                // Pad lhs.
                PrintPadding(singleOuterSidePaddingCount);

                // Print current line of symbols: lhs.
                PrintSymbols(rowSymbolCount / 2);

                // Pad inner center.
                PrintPadding(innerPaddingCount);

                // Print current line of symbols: rhs.
                PrintSymbols(rowSymbolCount / 2);

                // Pad rhs.
                PrintPadding(singleOuterSidePaddingCount);

                // Print newline.
                Console.WriteLine();

                // Decrement amount of symbols for next row by 2.
                rowSymbolCount -= 2;

                // Increment amount of whitespace padding for next row by 2.
                paddingCount += 2;
            }
        }

        private static void PrintSymbols(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write("#");
            }
        }

        private void PrintPadding(int paddingCount)
        {
            for (int i = 0; i < paddingCount; i++)
            {
                Console.Write(" ");
            }
        }
    }
}
