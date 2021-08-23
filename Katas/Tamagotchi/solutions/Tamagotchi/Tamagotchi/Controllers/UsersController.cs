using System.Collections.Generic;
using System.Linq;
using DataDtore.EF.Models;
using DataStore.EF;
using Microsoft.AspNetCore.Mvc;
// using System.LocalDataStoreSlot.EF;

namespace DefaultNamespace
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly PetContext _db;


        public UsersController(PetContext db)
        {
            _db = db;
        }
        
        [HttpGet]
        public List<User> Get()
        {
            return _db.Users.ToList();
        }
        
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var user = _db.Users.Find((id));
            if (user == null)
                return NotFound();
            
            return Ok(user);
        }

        [HttpGet]
        [Route("/users/{uId}/pets")]
        public IActionResult GetUserPet(int uId,[FromQuery] int petId)
        {
            var pets = _db.Pets.Where(p => p.UserId == uId).ToList();
            if (pets == null || pets.Count <= 0)
                return NotFound();

            return Ok(pets);
        }
        
        // [HttpPost]
        // public IActionResult Post([FromBody] User user)
        // {
        //     _db.Users.Add(user);
        //     // _db.SavedChanges();
        //     
        //     return CreatedAtAction((nameof(GetById), ))
        // }
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