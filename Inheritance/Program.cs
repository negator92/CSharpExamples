using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();

            Console.WriteLine($"{nameof(Parent)} {nameof(Parent.x)}, {nameof(Parent.y)}: {parent.x}, {parent.y}");
            Console.WriteLine($"{nameof(Child)} {nameof(child.x)}, {nameof(child.y)}, {nameof(child.z)}: {child.x}, {child.y}, {child.z}");
        }
    }
}