using Microsoft.EntityFrameworkCore;
using TestAppCore.DataLayerModels;

namespace TestAppCore.DBAccess
{
    public class TestApplicatioCoreContext: DbContext
    {
        public TestApplicatioCoreContext(DbContextOptions options)
        : base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<Users> Userses { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile").HasKey(a => new { a.UserProfileID });
            modelBuilder.Entity<Users>().ToTable("Users").HasKey(a => new { a.UserID });
        }
    }
}
