using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Puzzles
{
    /**
     * <summary>
     * 2-1 Write a program that produces the following shape:
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
    class MyTask2_3
    {
        public void PrintShape(int symbolCount)
        {
            CrossShape crossShape = new CrossShape();
            crossShape.Print(symbolCount);
        }
    }
}
