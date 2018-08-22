using System;

namespace OverloadUnoOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass exampleClass1 = new ExampleClass(100, 64);
            ExampleClass exampleClass2 = new ExampleClass(-74, 28);
            Console.WriteLine($"First obj: {exampleClass1.x} {exampleClass1.y}");
            Console.WriteLine($"Second obj: {exampleClass2.x} {exampleClass2.y}");

            ExampleClass exampleClass3 = exampleClass1 + exampleClass2;
            Console.WriteLine($"{nameof(exampleClass1)} + {nameof(exampleClass2)}: {exampleClass3.x} {exampleClass3.y}");

            exampleClass3 = exampleClass1 - exampleClass2;
            Console.WriteLine($"{nameof(exampleClass1)} - {nameof(exampleClass2)}: {exampleClass3.x} {exampleClass3.y}");
        }
    }

    class ExampleClass
    {
        public int x, y;

        public ExampleClass(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public static ExampleClass operator +(ExampleClass example1, ExampleClass example2)
        {
            ExampleClass exampleClass = new ExampleClass();
            exampleClass.x = example1.x + example2.x;
            exampleClass.y = example1.y + example2.y;
            return exampleClass;
        }

        public static ExampleClass operator -(ExampleClass example1, ExampleClass example2)
        {
            ExampleClass exampleClass = new ExampleClass();
            exampleClass.x = example1.x - example2.x;
            exampleClass.y = example1.y - example2.y;
            return exampleClass;
        }
    }
}