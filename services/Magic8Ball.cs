using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen___Endpoints.services
{
    public class Magic8Ball
    {
        public string Magic8BallMethod(string? userInput)
        {
            Random rng = new Random();
            string[] eightBallResponses = ["It is certain", "Try again", "Don't count on it", "Yes, Definitely", "I don't see that happening", "Doubtful", "Maybe it would be so", "My sources say no"];
            
            int randomNumber = rng.Next(8);

            if (userInput == "") {
                    return "Please enter a question";
            }

            return eightBallResponses[randomNumber];
        }
    }
}