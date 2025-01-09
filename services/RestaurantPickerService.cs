using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeEightToTen___Endpoints.services
{
    public class RestaurantPickerService
    {
        public string RestaurantPickerMethod(string? userInput)
        {
            Random rng = new Random();
            string[] italianRestaurants = ["La Dolce Vita Bistro", "Trattoria Bella", "Mamma Mia's Kitchen", "Il Forno Italiano", "Pasta e Basta", "Osteria del Sole", "Sapore di Napoli", "Vino & Vespa", "Gusto di Roma", "Cucina Toscana"];
            string[] mexicanRestaurants = ["El Sabor Mexicano", "Cantina del Sol", "Tierra y Fuego", "Casa de las Tacos", "La Frontera Grill", "Agave Azul Cantina", "Los Abuelos Cocina", "Pueblo y Paladar", "Taqueria El Corazon", "Mi Tierra Mexicana"];
            string[] chineseRestaurants = ["Golden Dragon Palace", "Jade Lotus Kitchen", "Imperial Wok House", "Red Latern Bistro", "Bamboo Garden Delight", "Dynasty Dumplings", "Szechuan Spice House", "Pearl of the Orient", "Dragonfly Dim Sum", "Mandarin Moon Cafe"];
            int randomNumber;

                userInput = userInput.ToLower();   

                //Validate user input
                if ((userInput != "a") && (userInput != "b") && (userInput != "c") && (userInput != "mexican") && (userInput != "chinese") && (userInput != "italian"))
                {
                    return "Invalid user input. Please try again." +"\nA. Mexican\nB. Chinese\nC. Italian";
                }

                //Generate random number to pass as index pointer
                randomNumber = rng.Next(10);

                if (userInput == "a" || userInput == "mexican") return $"Here is a great Mexican restaurant \"{mexicanRestaurants[randomNumber]}\" you should try.";
                else if (userInput == "b" || userInput == "chinese") return $"Here is a great Chinese restaurant \"{chineseRestaurants[randomNumber]}\" you should try.";
                else if (userInput == "c" || userInput == "italian") return $"Here is a great Italian restaurant \"{italianRestaurants[randomNumber]}\" you should try.";
                else return "You somehow got out of the options... HOW?!?!?!";           
        }
    }
}