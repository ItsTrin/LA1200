using System;

namespace Random_number_1_100
{
    class Program
    {

        static void Main(string[] args)
        {
            int userGuess = 0;
            string message = "Erraten Sie eine Zahl zwischen 1 und 100";
            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            Console.WriteLine(message);

            int tries = 0;
            var currentColor = Console.ForegroundColor;

            while (randomNumber != userGuess)
            {
                try
                {
                    userGuess = Convert.ToInt32(Console.ReadLine());

                    if (userGuess > randomNumber)
                    {
                        Console.WriteLine("Ihre Eingabe ist grösser als die zufällige Zahl.\n----------------------------------- ");
                        Console.Beep();
                    }
                    else if (userGuess != randomNumber)
                    {
                        Console.WriteLine("Ihre Eingabe ist kleiner als die zufällige Zahl.\n-----------------------------------");
                        Console.Beep();
                    }
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ihre Eingabe muss eine Zahl sein.");
                    Console.ForegroundColor = currentColor;
                    Console.WriteLine("-----------------------------------");
                    Console.Beep();
                }

                tries++;
            }

            if (tries <= 10)
            {
                Console.Write("Sie haben ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(tries);
                Console.ForegroundColor = currentColor;
                Console.WriteLine(" Versuche gebraucht um die Zahl zu erraten.");
            }
            else
            {
                Console.Write("Sie haben ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(tries);
                Console.ForegroundColor = currentColor;
                Console.WriteLine(" Versuche gebraucht um die Zahl zu erraten.");
            }
        }
    }
}