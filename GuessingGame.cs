using System;

namespace GuessingGame
{
    class GuessingGame
    {
        int answer;
        int guess;
        int guesses;
        Random random = new Random();

        public GuessingGame()
        {
            answer = 0;
            guess = 0;
            guesses = 0;
        }
     
        public void PlayGame()
        {
            guess = 0;
            guesses++;
            answer = random.Next(1, 100 + 1);
            Console.WriteLine("Guess a number between 1 and 100..");

            while (guess != answer)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess < answer)
                    {

                        Console.WriteLine("Sorry, wrong guess. The answer is bigger than: " + guess);
                        guesses++;
                    }
                    else if (guess > answer)
                    {
                        Console.WriteLine("Sorry, wrong guess. The answer is smaller than: " + guess);
                        guesses++;
                    }
                } catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid integer 1 through 100, thank you. Good luck");
                }
            }

            Console.WriteLine("Congrats, you got the correct answer." + "\n" + 
                              "It took you this many guesses: " + guesses + "\n" +
                              "The answer was: " + answer);
        }

        public void Reset()
        {
            answer = 0;
            guess = 0;
            guesses = 0;
        }

        public static void Main(string[] args)
        {
            GuessingGame program = new GuessingGame();
            program.PlayGame();

            String again;
            Console.WriteLine("Do you want to play again? Type Yes or No");
            again = Console.ReadLine();
            if (again == "no" || again == "No" || again == "NO" || again == "n")
            {
                Environment.Exit(0);
            }
            do
            {
                program.Reset();
                program.PlayGame();
                Console.WriteLine("Do you want to continue playing? Type Yes or No");
                again = Console.ReadLine();
                if (again == "no" || again == "No" || again == "NO" || again == "n")
                {
                    Environment.Exit(0);
                }
            } while (again != "no" || again != "No" || again != "NO" || again != "n");
        }
    }
}
