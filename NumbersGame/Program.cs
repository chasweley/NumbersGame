using System.Globalization;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer mellan 1 och 20. Kan du gissa vilket? Du får fem försök.");

            Random random = new Random();
            int number = random.Next(1, 20); //Creates a random number between 1 and 20

            int i = 0;
            int guess = 0;

            while (i < 5 && !CheckIfCorrect(guess, number)) //Loop to limit number of guesses and calls function to check if incorrect guess
            {
                guess = int.Parse(Console.ReadLine()); //User input for guess

                if (CheckIfCorrect(guess, number)) //If guess is correct
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                }

                else //If guess is incorrect
                {
                    Console.WriteLine($"Tyvärr, du gissade för {HighLow(guess, number)}!"); //Calls function to print string if guess is too low or too high
                }
            
                if (i == 4 && !CheckIfCorrect(guess, number)) //If-statment for last iteration (i) allowed and guess is incorrect
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!"); //Print that guess is incorrect and no more tries
                }

                i++;

            }

        }

        static bool CheckIfCorrect(int guess, int number) //Function to check if guess is equal to number
        {
            return guess == number; //Returns true or false
        }

        static string HighLow(int guess, int number) //Function to return string if the guess is too low or too high
        {
            if (guess < number)
            {
                return "lågt";
            }

            else
            {
                return "högt";
            }
        }
    }
}