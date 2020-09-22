using System;

namespace SimpleScript
{
    class Program
    {
        static void Main(string[] args)
        {
            String fileName = args[0];
            String file = System.IO.File.ReadAllTextAsync(fileName).Result;

            Lexical lexical = new Lexical(file);

            while (lexical.GetFileIndex() != file.Length)
            {
                Token token = lexical.NextToken();
                Console.Out.WriteLine(token.Primary);
                Console.Out.WriteLine(token.Secundary);
            }

            // throw new NotImplementedException();
        }
    }
}
