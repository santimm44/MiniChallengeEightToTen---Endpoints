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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _RestaurantPickerService;
        public RestaurantPickerController(RestaurantPickerService restaurantPickerService)
        {
            _RestaurantPickerService = restaurantPickerService;
            
        }

        [HttpGet]
        [Route("RestaurantPicker/{PickMexicanItalianOrChinese}")]
        public string GetRestaurantPicker(string PickMexicanItalianOrChinese)
        {
            return _RestaurantPickerService.RestaurantPickerMethod(PickMexicanItalianOrChinese);
        }
    }
}