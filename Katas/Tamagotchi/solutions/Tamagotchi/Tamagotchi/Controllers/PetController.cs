using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tamagotchi.Models;

namespace Tamagotchi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetController : ControllerBase
    {
        public List<Pet> Pets { get; set; }

        public PetController()
        {
            Pets = new List<Pet>()
            {
                new Dog()
                {
                    Happiness = 0,
                    Hunger = 0,
                    Type = "Dog"
                },
                new Dog()
                {
                    Happiness = 1,
                    Hunger = 2,
                    Type = "anotherDog"
                }
            };
        }
       
        
        [HttpGet]
        public List<Pet> Get()
        {
            return Pets;
        }
    }
}