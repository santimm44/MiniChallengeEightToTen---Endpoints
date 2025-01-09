using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen___Endpoints.services;

namespace MiniChallengeEightToTen___Endpoints.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _GuessItService;

        public GuessItController(GuessItService guessItService)
        {
            _GuessItService = guessItService;
        }

        [HttpGet]
        [Route("GuessItEasy/{guessNumber}")]
        public string EasyMode(int guessNumber)
        {
            return _GuessItService.GuessItMethod(1, guessNumber);
        }
        [HttpGet]
        [Route("GuessItMed/{guessNumber}")]
        public string MedMode(int guessNumber)
        {
            return _GuessItService.GuessItMethod(2, guessNumber);
        }
        [HttpGet]
        [Route("GuessIthard/{guessNumber}")]
        public string HardMode(int guessNumber)
        {
            return _GuessItService.GuessItMethod(3, guessNumber);
        }
    }
}