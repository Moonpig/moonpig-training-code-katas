using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Tamagotchi.Models;

namespace DefaultNamespace
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        
        public List<User> Users { get; set; }

        public UsersController()
        {
            Users = new List<User>()
            {
                new User()
                {
                    UserId = 1,
                    OwnerName = "John",
                },
                new User()
                {
                    UserId = 2,
                    OwnerName = "Sara",
                    Pets = new List<Pet>()
                }
            };
        }
        
        [HttpGet]
        public List<User> Get()
        {
            return Users;
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok($"Reading the user #{id}.");
        }

        [HttpGet]
        [Route("/users/{uId}/pets")]
        public IActionResult GetUserPet(int uId,[FromQuery] int petId)
        {
            if (petId == 0)
            {
                return Ok($"Reading all the tickets belong to the project #{uId}.");
            }
            return Ok($"Reading the project #{uId}, ticket #{petId}.");
        }
        
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("add a user");
        }
        [HttpPost]
        public User AddUser([FromBody]int id, string name)
        {
            var user = new User()
            {
                UserId = id,
                OwnerName = name
            };
            return user;
        }
        
        [HttpPut]
        public IActionResult Put(int id)
        {
            return Ok($"updating the user #{id}");
        }
        
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting the user #{id}.");
        }
    }
}