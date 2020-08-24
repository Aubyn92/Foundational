using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace basic_coding
{
    public class GuessTheNumber
    {
        public void GuessingGame()
        {
            // Task 8: Write a guessing game where the user has to guess a secret number. 
            // After every guess the program tells the user whether their number was too large or too small. 
            // At the end the number of tries needed should be printed. 
            // It counts only as one try if they input the same number multiple times consecutively:

            int randomNumber = new Random().Next(1, 101); 
            int inputGuess; 
            int countInputGuess = 0; 
            Boolean userWin = false; 

            while (userWin != true)
            {
                Console.Write("Take your guess between 1 and 100: ");
                countInputGuess++;

                var userInput = Console.ReadLine();
                if (validateInput(userInput))
                {
                    Console.WriteLine(evaluateAnswer());
                }
                else
                {
                    Console.WriteLine("Not a valid number.");
                }

                bool validateInput(String userInput)
                {
                    if (int.TryParse(userInput, out inputGuess))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                String evaluateAnswer()
                {
                    if (inputGuess == randomNumber)
                    {
                        userWin = true;
                        return $"\nYou've won, yay! The number is { randomNumber }. You attempted it { countInputGuess } times. Woop woop! ";
                    }
                    else if (inputGuess < randomNumber)
                    {
                        return $"\nToo low! You have attempted { countInputGuess } times. Try again: ";
                    }
                    else
                    {
                        return $"\nToo high! You have attempted { countInputGuess } times. Try again:";
                    }
                }
            }
        }
    }
}