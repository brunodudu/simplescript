using System;

namespace SimpleScript
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = args[0];
            String file = System.IO.File.ReadAllTextAsync(fileName).Result;

            var Lexical = new Lexical(file);

            throw new NotImplementedException();
        }
    }
}
