using System;

namespace Library
{
    /// <summary>
    /// Library to generate hello message.
    /// </summary>
    public static class HelloGenerator
    {
        /// <summary>
        /// Generate hello message.
        /// </summary>
        /// <param name="name">Person name.</param>
        /// <exception cref="ArgumentNullException">Throw when <paramref name="name"/> is null.</exception>
        /// <returns>Hello message with current time.</returns>
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
