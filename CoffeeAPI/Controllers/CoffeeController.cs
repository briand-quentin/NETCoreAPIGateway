using System;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeController : ControllerBase
    {
        private static readonly string[] Coffees = {
            "Coffee 1", "Coffee 2", "Coffee 3", "Coffee 4"
        };

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(Coffees[rng.Next(Coffees.Length)]);
        }
    }
}