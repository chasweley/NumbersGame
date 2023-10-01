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

            for (int i = 0; i < 5; i++) //Loop to limit number of guesses
            {
                int guess = int.Parse(Console.ReadLine()); //User input for guess

                if (CheckIfEqual(guess, number)) //If-statement calls function to check if the guess is correct
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break; //If method true, break loop
                }
                else if (guess < number) //If guess lower than number
                {
                    Console.WriteLine("Tyvärr du gissade för lågt!"); //Print that guess is too low 
                }
                else if (guess > number) //If guess higher than number
                {
                    Console.WriteLine("Tyvärr du gissade för högt!"); //Print that the guess is too high 
                }
                if (i == 4 && guess != number) //If interation is equal to four (last iteration allowed) and guess is not equal to number
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!"); //Print that guess is incorrect and no more tries
                }

            }

        }

        static bool CheckIfEqual(int guess, int number) //Function to check if guess is equal to number
        {
            return guess == number; //Returns true or false
        }
    }
}