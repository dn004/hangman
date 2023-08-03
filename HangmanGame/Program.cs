using System;

class HangmanGame
{
    static void Main()
    {
        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Try to guess the word by guessing one letter at a time.");
        Console.WriteLine("You have 6 attempts to guess the word correctly.");
        
        // The word to be guessed
        string secretWord = "hangman";

        // Create a char array to keep track of guessed letters
        char[] guessedLetters = new char[secretWord.Length];

        // Initialize guessedLetters with underscores to represent unguessed letters
        for (int i = 0; i < guessedLetters.Length; i++)
        {
            guessedLetters[i] = '_';
        }

        int attempts = 6;
        bool gameWon = false;

        while (attempts > 0)
        {
            // Display the guessed letters so far
            Console.WriteLine("\nWord: " + string.Join(" ", guessedLetters));

            // Prompt the user to guess a letter
            Console.Write("Guess a letter: ");
            char guessedLetter = char.ToLower(Console.ReadKey().KeyChar);

            // Check if the guessed letter is in the secret word
            bool letterFound = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guessedLetter)
                {
                    guessedLetters[i] = guessedLetter;
                    letterFound = true;
                }
            }

            // If the letter is not found, decrement the attempts count
            if (!letterFound)
            {
                attempts--;
                Console.WriteLine($"\nIncorrect! Attempts left: {attempts}");
            }

            // Check if the word has been completely guessed
            if (new string(guessedLetters) == secretWord)
            {
                gameWon = true;
                break;
            }
        }

        if (gameWon)
        {
            Console.WriteLine("\nCongratulations! You guessed the word: " + secretWord);
        }
        else
        {
            Console.WriteLine("\nSorry, you ran out of attempts. The word was: " + secretWord);
        }
    }
}
