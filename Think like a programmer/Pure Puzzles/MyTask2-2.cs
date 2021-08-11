using System;

namespace Pure_Puzzles
{
    /**
     * <summary>
     * 2-1 Write a program that produces the following shape:
     *      ##
     *     ####
     *    ######
     *   ########
     *   ########
     *    ######
     *     ####
     *      ##
     *
     * Given the following limitations:
     * Only cw allowed is: Console.Write("#"), Console.Write(" ") and Console.WriteLine(...)
     * </summary>
     */
    class MyTask2_2
    {
        public void PrintShape(int symbolCount)
        {
            PyramidShape pyramidShape = new PyramidShape();
            
            pyramidShape.Print(symbolCount);
            pyramidShape.PrintUpsideDown(symbolCount);
        }
    }
}
