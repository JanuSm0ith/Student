using Student.Models.Domain;

namespace Student.Repositories
{
    public interface IUserRepository
    {

        Task<User> AuthenticateAsync(string username, string password);
    }
}
