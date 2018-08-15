using System;
using System.IO;

namespace wordscount
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            string[] txt;
            s = File.ReadAllText("file.txt");
            Console.WriteLine(s);
            txt = s.Split(' ');
            Console.WriteLine($"Words count: {txt.Length}");
        }
    }
}