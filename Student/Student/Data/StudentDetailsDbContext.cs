using Microsoft.EntityFrameworkCore;
using Student.Models.Domain;

namespace Student.Data
{
    public class StudentDetailsDbContext : DbContext
    {
        public StudentDetailsDbContext(DbContextOptions<StudentDetailsDbContext> options): base(options) 
          {



           }
        public DbSet<StudentDetail> StudentDetails { get; set; }
    }
}
