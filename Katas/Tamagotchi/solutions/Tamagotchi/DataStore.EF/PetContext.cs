using DataDtore.EF.Models;
using Microsoft.EntityFrameworkCore;

namespace DataStore.EF
{
    public class PetContext : DbContext
    {
        public PetContext(DbContextOptions options) : base(options)
        {
        }
        
        public  DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Pets)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
            
            //seeding
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, OwnerName = "Peter" },
                new User { UserId = 2, OwnerName = "Tom" },
                new User { UserId = 3, OwnerName = "Pedro" }
            );

            modelBuilder.Entity<Pet>().HasData(
                new Pet{ PetId = 11, Happiness = 0, Hunger = 0, UserId = 1, TypeName = "Cat"},
                new Pet{ PetId = 22, Happiness = 0, Hunger = 0, UserId = 2, TypeName = "Dog"},
                new Pet{ PetId = 33, Happiness = 0, Hunger = 0, UserId = 3, TypeName = "Dog"},
                new Pet{ PetId = 44, Happiness = 0, Hunger = 0, UserId = 3, TypeName = "Dog"}
            );
        }
    }
}