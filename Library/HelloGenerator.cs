using System;

namespace Library
{
    public static class HelloGenerator
    {
        public static string GetHello(string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return $"{DateTime.Now:hh.mm.s} Hello, {name}!";
        }
    }
}
