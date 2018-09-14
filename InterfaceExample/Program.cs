using System;

namespace InterfaceExample
{
    class Program
    {
        static void Main()
        {
            Test test = new Test();
            int test1 = test.Test1();
            int test2 = test.Test2();
            Console.WriteLine($"{test1}, {test2}");
        }
    }
}