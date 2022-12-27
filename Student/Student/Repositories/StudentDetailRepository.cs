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

        public async Task<StudentDetail> AddAsync(StudentDetail studentDetail)
        {
            studentDetail.Id = Guid.NewGuid();
            await studentDetailsDbContext.AddAsync(studentDetail);
            await studentDetailsDbContext.SaveChangesAsync();
            return studentDetail;
        }

        public async Task<StudentDetail> DeleteAsync(Guid id)
        {
            var student = await studentDetailsDbContext.StudentDetails.FirstOrDefaultAsync(x => x.Id == id);
            if(student == null)
            {
                return null;
            }

            //Delete the student
            studentDetailsDbContext.StudentDetails.Remove(student);
            studentDetailsDbContext.SaveChangesAsync();
            return student;


        }

        public async  Task<IEnumerable<StudentDetail>> GetAllAsync()
        {
           return await studentDetailsDbContext.StudentDetails.ToListAsync();


        }

        public async Task<StudentDetail> GetAsync(Guid id)
        {
            //var student = studentDetailsDbContext.StudentDetails.FirstOrDefaultAsync(x => x.Id == id);
            //return student;
            return await studentDetailsDbContext.StudentDetails.FirstOrDefaultAsync(x => x.Id == id);


        }

        public async Task<StudentDetail> UpdateAsync(Guid id, StudentDetail student)
        {
           var existingstudent = await studentDetailsDbContext.StudentDetails.FirstOrDefaultAsync(x => x.Id == id);
            if(existingstudent == null)
            {
                return null;

            }
            existingstudent.Name = student.Name;
            existingstudent.City = student.City;
            await studentDetailsDbContext.SaveChangesAsync();
            return existingstudent;
        }
    }
}
