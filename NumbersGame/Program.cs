using System.Globalization;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20);

            for (int i = 0; i < 5; i++)
            {
                int guess = int.Parse(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else if (guess < number) {
                    Console.WriteLine("Tyvärr du gissade för lågt!");
                }
                else
                {
                    Console.WriteLine("Tyvärr du gissade för högt!");
                }
            }
    }
}