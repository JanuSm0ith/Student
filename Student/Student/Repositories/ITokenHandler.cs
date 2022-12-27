using Student.Models.Domain;

namespace Student.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);

    }
}
