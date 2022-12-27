using Microsoft.EntityFrameworkCore;
using Student.Data;
using Student.Models.Domain;

namespace Student.Repositories
{
    public class StudentDetailRepository : IStudentDetailRepository
    {
        private StudentDetailsDbContext studentDetailsDbContext;

        public StudentDetailRepository(StudentDetailsDbContext studentDetailsDbContext)
        {
            this.studentDetailsDbContext = studentDetailsDbContext;

        }
        public async  Task<IEnumerable<StudentDetail>> GetAllAsync()
        {
           return await studentDetailsDbContext.StudentDetails.ToListAsync();


        }
    }
}
