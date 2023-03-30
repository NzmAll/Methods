using System;

class Program
{
    static void Main(string[] args)
    {
        string[] currencies = new string[] { "USD", "RUB", "TRY" };
        double[] currenciesWorth = new double[] { 1.7, 0.023, 0.18 };
        Element(currencies, currenciesWorth);

    static void Element(string[]currencies, double[] currenciesWorth)
        {
            while (true)
            {
                Console.WriteLine("Komandalar :");
                Console.WriteLine("/show-recent-currency-currenciesWorth");
                Console.WriteLine("/find-currency-rate-by-code");
                Console.WriteLine("/calculate-amount-by-currecy");
                Console.WriteLine("/exit");

                string command = Console.ReadLine()!;

                if (command == "/show-recent-currency-currenciesWorth")
                {
                    int i = 0;

                    while (i < currencies.Length)
                    {
                        Console.WriteLine(currencies[i] + currenciesWorth[i]);
                        i++;

                    }
                }
                else if (command == "/find-currency-rate-by-code")
                {
                    Console.Write("Məzənnənin alpha3 kodu daxil edin: ");

                    string currencyCode = Console.ReadLine()!;

                    int index = -1;

                    for (int i = 0; i < currencies.Length; i++)
                    {
                        if (currencies[i] == currencyCode)
                        {
                            index = i;
                            break;
                        }
                    }
                    if (index == -1)
                    {
                        Console.WriteLine("Belə məzənnə yoxdur.");
                    }

                    else
                    {
                        Console.WriteLine(currencyCode + currenciesWorth[index]);
                    }
                }
                else if (command == "/calculate-amount-by-currency")
                {
                    Console.Write("Məbləği daxil edin: ");

                    double amount = Convert.ToDouble(Console.ReadLine()!);

                    Console.Write("Məzənnənin alpha3 kodu daxil edin: ");

                    string currencyCode = Console.ReadLine()!;

                    int index = -1;

                    for (int i = 0; i < currencies.Length; i++)
                    {
                        if (currencies[i] == currencyCode)
                        {
                            index = i;
                            break;
                        }

                    }

                    if (index == -1)
                    {
                        Console.WriteLine("Not found");

                    }

                    else
                    {
                        double total = amount * currenciesWorth[index];
                        Console.WriteLine("Nəticə: " + total);

                    }
                }

                else if (command == "/exit")
                {
                    Console.WriteLine("Programdan çıxılır.");
                    break;

                }
                else
                {
                    Console.WriteLine("Düzgün komanda daxil edilmədi.");

                }
            }
        }
        
    }
}