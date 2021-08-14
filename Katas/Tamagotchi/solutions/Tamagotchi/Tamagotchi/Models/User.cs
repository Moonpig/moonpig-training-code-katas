using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Tamagotchi.Models
{
    public class User
    {
        public int UserId { get; set; }
        
        [Required] 
        public string OwnerName { get; set; }
        
        public List<Pet> Pets { get; set; }
        
    }
}