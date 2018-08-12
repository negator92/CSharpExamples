using System;
using System.IO;
using System.Text;

namespace StreamReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
//            Console.OutputEncoding = Encoding.UTF8;
            string dir = Environment.CurrentDirectory;
            string[] txts = Directory.GetFiles(dir, "*.txt");
            StreamReader streamReader = new StreamReader(txts[0], Encoding.Default);
            while (!streamReader.EndOfStream)
                Console.WriteLine(streamReader.ReadLine());
            streamReader.Close();
        }
    }
}