using Library;
using Microsoft.Extensions.Configuration;
using System;

namespace Task1._1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .Build();

            string name = config["name"];
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Write your name, please:");
                name = Console.ReadLine();
            }

            Console.WriteLine(HelloGenerator.GetHello(name));
            Console.ReadKey();
        }
    }
}
