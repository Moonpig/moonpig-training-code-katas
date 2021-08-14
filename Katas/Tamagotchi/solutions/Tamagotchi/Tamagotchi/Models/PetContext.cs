using Microsoft.EntityFrameworkCore;

namespace Tamagotchi.Models
{
    public class PetContext: DbContext
    {
        public PetContext(DbContextOptions  options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Pets)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}