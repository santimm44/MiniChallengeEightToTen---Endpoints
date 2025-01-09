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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8Ball _Magic8Ball;

        public Magic8BallController (Magic8Ball magic8Ball)
        {
            _Magic8Ball = magic8Ball;
        }

        [HttpGet]
        [Route("Magic8Ball/{question}")]
        public string GetMagic8Ball (string? question)
        {
            return _Magic8Ball.Magic8BallMethod(question);
        }
    }
}