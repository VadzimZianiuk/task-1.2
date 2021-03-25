using System;
using Library;
using Microsoft.Extensions.Configuration;

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
            Console.WriteLine(string.IsNullOrEmpty(name)
                ? $"Please, use commandline -name 'Your name'."
                : HelloGenerator.GetHello(name));
        }
    }
}
