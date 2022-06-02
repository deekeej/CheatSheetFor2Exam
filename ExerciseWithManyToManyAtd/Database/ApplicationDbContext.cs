using ExerciseWithManyToManyAtd.Modells;
using Microsoft.EntityFrameworkCore;

namespace ExerciseWithManyToManyAtd.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Party> Parties { get; set; }
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasMany(u => u.PartyList).WithMany(p => p.UserList);
        }
    }
}
