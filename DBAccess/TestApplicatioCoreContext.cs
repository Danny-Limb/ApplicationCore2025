using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TestAppCore.DataLayerModels;

namespace TestAppCore.DBAccess
{
    public class TestApplicatioCoreContext: DbContext
    {
        public TestApplicatioCoreContext(DbContextOptions<TestApplicatioCoreContext> options): base(options)
        {
        }

        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile");
            modelBuilder.Entity<Users>().ToTable("Users");

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
