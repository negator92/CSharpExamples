using System;

namespace Chapter5
{
    class Program
    {
        class SysInfo
        {
            public string win, net, cpu;
            public string hostname, username;

            public SysInfo()
            {
                net = Environment.Version.ToString();
                win = Environment.OSVersion.ToString();
                cpu = Environment.ProcessorCount.ToString();
                hostname = Environment.MachineName.ToString();
                username = Environment.UserName.ToString();
            }
        }

        static void Main(string[] args)
        {
            string p;

            SysInfo info = new SysInfo();

            if (args.Length > 0)
                p = args[0];
            else
            {
                p = "null";
                //Console.WriteLine($"CPU count: {info.cpu}");
                //Console.WriteLine($"Windows Version: {info.win}");
                //Console.WriteLine($".NET Version: {info.net}");
                //Console.WriteLine($"Hostname: {info.hostname}");
                //Console.WriteLine($"Username: {info.username}");
            }

            switch (p)
            {
                case "cpu":
                    Console.WriteLine($"CPU count: {info.cpu}");
                    break;
                case "win":
                    Console.WriteLine($"Windows Version: {info.win}");
                    break;
                case "net":
                    Console.WriteLine($".NET Version: {info.net}");
                    break;
                case "host":
                    Console.WriteLine($"Hostname: {info.hostname}");
                    break;
                case "user":
                    Console.WriteLine($"Username: {info.username}");
                    break;
                default:
                    Console.WriteLine("Usage: sysinfo <cpu|win|net|host|user>");
                    break;
            }
        }
    }
}