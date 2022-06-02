using Microsoft.EntityFrameworkCore;
using OrientationExamTryJava.Models;

namespace OrientationExamTryJava.Database
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Aliaser> Aliasers { get; set; }
		public DbSet<Applicant> Applicats { get; set; }

		public ApplicationDbContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* modelBuilder.Entity<Message>().HasKey(p => p.Id);
            modelBuilder.Entity<Peer>().HasKey(p => p.IpPort);*/
        }
    }
}
