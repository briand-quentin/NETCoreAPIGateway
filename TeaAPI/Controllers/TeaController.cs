using System;
using Microsoft.AspNetCore.Mvc;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = {
            "Tea 1", "Tea 2", "Tea 3", "Tea 4", "Tea 5", "Tea 6",
        };

        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(Teas[rng.Next(Teas.Length)]);
        }
    }
}