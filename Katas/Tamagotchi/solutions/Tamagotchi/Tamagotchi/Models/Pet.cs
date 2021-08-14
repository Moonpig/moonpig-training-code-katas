using System.ComponentModel.DataAnnotations;

namespace Tamagotchi.Models
{
    public class Pet
    {
        [Required]
        public int? PetId { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        public string TypeName { get; set; }
        public int Happiness { get; set; }
        public int Hunger { get; set; }
      
    }
}