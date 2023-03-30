using System;
using System.Linq;

namespace Practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci arrayi daxil edin: ");
            int[] numberOne = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Console.Write("Ikinci arrayi daxil edin: ");
            int[] numberTwo = Console.ReadLine()!.Split().Select(int.Parse).ToArray();

            Element(numberOne, numberTwo);
        }

        static void Element(int[] numberOne, int[] numberTwo)
        {
            bool check = false;

            for (int i = 0; i < numberOne.Length; i++)
            {
                for (int j = 0; j < numberTwo.Length; j++)
                {
                    if (numberOne[i] == numberTwo[j])
                    {
                        check = true;
                        break;
                    }
                }
            }

            if (check)
            {
                Console.WriteLine("Birincinin daxilinde ikinci arrayden ededler var");
            }
            else
            {
                Console.WriteLine("Birincinin daxilinde ikinci arrayden ededler yoxdur");
            }
        }
    }
}
