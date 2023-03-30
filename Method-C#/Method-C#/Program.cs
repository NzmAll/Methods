using System;

namespace Method_C_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Adi daxil edin: ");
            string name = Console.ReadLine()!;

            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Element(name, uppercaseLetters, lowerLetters);
        }

        static void Element(string name, char[] uppercaseLetters, char[] lowerLetters)
        {
            bool check = false;

            for (int i = 0; i < name.Length; i++)
            {
                for (int j = 0; j < uppercaseLetters.Length; j++)
                {
                    if (name[i] == uppercaseLetters[j] || name[i] == lowerLetters[j])
                    {
                        check = true;
                        break;
                    }
                    else
                    {
                        check = false;
                    }
                }
            }
            if (check == true)
            {
                Console.WriteLine("Kodda herf var");
            }
            else
            {
                Console.WriteLine("Kodda reqem var");
            }
        }
    }
}
