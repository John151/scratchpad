using System;

namespace scratchpad
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "John";
            char firstLetterOfName = name[0];
            Console.WriteLine(firstLetterOfName);
            
            
            //reverse
            string reversed = Reverse(name);
            char lastLetter = reversed[0];
            Console.WriteLine(lastLetter);

            char star = '*';

            Console.WriteLine(star);
           
            Console.ReadKey();
        }

        private static string Reverse(string name)
        {
            char[] charArray = name.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

            //found on stack overflow
            //https://stackoverflow.com/questions/228038/best-way-to-reverse-a-string
        }
    }
}
