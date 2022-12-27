using Student.Models.Domain;

namespace Student.Repositories
{
    public interface IStudentDetailRepository
    {

        Task<IEnumerable<StudentDetail>> GetAllAsync();
        Task<StudentDetail> GetAsync(Guid id);

         Task<StudentDetail>AddAsync(StudentDetail studentDetail);

        Task<StudentDetail> DeleteAsync(Guid id);

        Task<StudentDetail> UpdateAsync(Guid id,StudentDetail studentDetail);
    }
}
