using Student.Models.Domain;

namespace Student.Repositories
{
    public interface IStudentDetailRepository
    {
        Task<IEnumerable<StudentDetail>> GetAllAsync();
    }
}
