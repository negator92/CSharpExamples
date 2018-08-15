using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();

            int i = random.Next(10);

            Console.WriteLine("PC know number from 0 to 9");
            if (i < 5)
                Console.WriteLine("Number is lower than 5");
            else
                Console.WriteLine("Number is equal or bigger than 5");
            int x = Convert.ToInt32(Console.ReadLine());

            if (i == x)
                Console.WriteLine("Congradulations! You guess!");
            else
                Console.WriteLine($"Sorry, PC number was {i}");

            Main();
        }
    }
}