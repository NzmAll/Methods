using System;

namespace Method_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool isTrue = true;
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Stringi daxil edin: ");
            string name = Console.ReadLine()!;

            isTrue = Element(name, uppercaseLetters, lowerLetters);

            if (isTrue == true)
            {
                Console.WriteLine("Herf yoxdur");
            }
            else if (isTrue == false)
            {
                Console.WriteLine("Herf var");
            }
        }

        static bool Element(string name, char[] uppercaseLetters, char[] lowerLetters)
        {
            bool isTrue = true;
            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < uppercaseLetters.Length; j++)
                {
                    if (name[i] == uppercaseLetters[j] || name[i] == lowerLetters[j])
                    {
                        isTrue = false;
                        break;
                    }
                }
                return isTrue;
            }
            return isTrue;
        }
    }
}
