using System;
using _010_Task01;

namespace _000_EnterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("  | Run Task_01   |\n  | press any key |\n");
            Console.ReadKey(); Console.Clear();
            Task01 tsk01 = new Task01(); tsk01.Run();

        }
    }
}
