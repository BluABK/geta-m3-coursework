using System;

namespace Pure_Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTask2_1 task2_1 = new MyTask2_1();

            Console.WriteLine("Task 2-1:");
            task2_1.Run();

            // Add trailing newline to avoid clutter after exiting.
            Console.WriteLine();
        }
    }
}
