using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataDtore.EF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Tamagotchi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PetsController : ControllerBase
    {
        public List<Pet> Pets { get; set; }
        // private readonly PetContext _context;

        // public PetController(PetContext context)
        // {
        //     _context = context;
        // }
        
        public PetsController()
        {
            Pets = new List<Pet>()
            {
                new Dog()
                {
                    PetId = 1,
                    Happiness = 0,
                    Hunger = 0,
                    TypeName = "Dog"
                },
                new Dog()
                {
                    PetId = 2,
                    Happiness = 1,
                    Hunger = 2,
                    TypeName = "anotherDog"
                },
                new Cat()
                {
                    PetId = 4,
                    Happiness = 3,
                    TypeName = "Kitty",
                    Hunger = 2,
                    UserId = 1
                }
            };
        }
       
        
        [HttpGet]
        public List<Pet> Get()
        {
            return Pets;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
           var pet = Pets.Where(x=> x.PetId == id);
            return Ok($"Reading the pet #{id}. {pet}");
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("creating pet");
        }

        [HttpPut]
        public IActionResult Put(int id)
        {
            return Ok($"updating the pet #{id}");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting the pet #{id}.");
        }
        
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Pet>> GetPet(int id)
        // {
        //     var pet = await _context.Pets.FindAsync(id);
        //
        //     if (pet == null)
        //     {
        //         return NotFound();
        //     }
        //
        //     return pet;
        // }
        
    }
}