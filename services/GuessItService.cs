using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen___Endpoints.services
{
    public class GuessItService
    {
        public string GuessItMethod(int userChoice, int userGuess)
        {
            int maxValue;

            switch (userChoice)
            {
                case 1:
                    maxValue = 10;
                    return GuessMethod(maxValue, userGuess);

                case 2:
                    maxValue = 50;
                    return GuessMethod(maxValue, userGuess);

                case 3:
                    maxValue = 100;
                    return GuessMethod(maxValue, userGuess);

                default:
                    return "Ruh-Roh! How did you break the code?";
            }
        }

        public string GuessMethod(int maxValue, int userGuess)
        {
            Random rng = new Random();
            int randomNumber;

            randomNumber = rng.Next(maxValue);

            if (userGuess == randomNumber) return "Wow! You got it on the first try!";
            else
            {
                //validate userguess to make sure it's within range of difficulty
                if (userGuess>maxValue)
                {
                    return $"You are beyond bounds of the difficult settings. Guess within range of 0-{maxValue}";
                }
                else if (userGuess < 0)
                {
                    return $"You are below zero. Guess within range of 0-{maxValue}";
                }


                if (userGuess > randomNumber)
                {
                    return "Too high.";
                }
                else
                {
                    return "Too low.";
                }
            }
        }
    }
}