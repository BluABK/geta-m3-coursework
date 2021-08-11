using System;

namespace Pure_Puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            MyTask2_1 task2_1 = new MyTask2_1();

            Console.WriteLine("Task 2-1:");
            task2_1.PrintShape(8);

            // Add vertical padding between tasks for increased readability.
            Console.WriteLine();

            MyTask2_2 task2_2 = new MyTask2_2();

            Console.WriteLine("Task 2-2:");
            task2_2.PrintShape(8);

            // Add trailing newline to avoid clutter after exiting.
            Console.WriteLine();
        }
    }
}
