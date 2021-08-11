using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Puzzles
{
    class PyramidShape
    {
        public void Print(int symbolCount)
        {
            int rows = symbolCount / 2;
            int rowSymbolCount = 2;
            int paddingCount = symbolCount - 2;

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

                // Increment amount of symbols for next row by 2.
                rowSymbolCount += 2;

                // Decrement amount of whitespace padding for next row by 2.
                paddingCount -= 2;
            }
        }

        public void PrintUpsideDown(int symbolCount)
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
