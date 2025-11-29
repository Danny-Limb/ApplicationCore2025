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

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server = .; Database = MVCApplication; Trusted_Connection = True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserProfile>().ToTable("UserProfile").HasKey(a => new { a.UserProfileID });
            modelBuilder.Entity<Users>().ToTable("Users").HasKey(a => new { a.UserID });

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
