namespace PracticeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Metni daxil edin: ");
            string text = Console.ReadLine()!;
            Element(text);

        }
        static void Element(string text)
        {
            bool check = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '0' || text[i] == '1' || text[i] == '2' || text[i] == '3' || text[i] == '4' ||
                    text[i] == '5' || text[i] == '6' || text[i] == '7' || text[i] == '8' || text[i] == '9')
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            if (check == true)
            {
                Console.WriteLine("Reqem var");
            }
            else
            {
                Console.WriteLine("Reqem yoxdur");
            }
        }
    }
}