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
                    Name = "John"
                },
                new User()
                {
                    UserId = 2,
                    Name = "Sara"
                }
            };
        }
        
        [HttpGet]
        public List<User> Get()
        {
            return Users;
        }
    }
}