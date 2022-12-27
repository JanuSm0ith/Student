using Microsoft.EntityFrameworkCore;
using Student.Models.Domain;

namespace Student.Data
{
    public class StudentDetailsDbContext : DbContext
    {
        public StudentDetailsDbContext(DbContextOptions<StudentDetailsDbContext> options): base(options) 
          {

            }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User_Role>()
                .HasOne(x => x.Role)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(x => x.RoleId);

            modelBuilder.Entity<User_Role>()
                .HasOne(x => x.User)
                .WithMany(y => y.UserRoles)
                .HasForeignKey(x => x.UserId);
        }

        public DbSet<StudentDetail> StudentDetails { get; set; }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User_Role> Users_Roles { get; set; }
    }
}
