using Microsoft.EntityFrameworkCore;
using Student.Data;
using Student.Models.Domain;

namespace Student.Repositories
{
    public class UserRepository:IUserRepository
    {
        private StudentDetailsDbContext studentDetailsDbContext;

        public UserRepository(StudentDetailsDbContext studentDetailsDbContext)
        {
            this.studentDetailsDbContext = studentDetailsDbContext;
        }
        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = await studentDetailsDbContext.Users
                .FirstOrDefaultAsync(x => x.Username.ToLower() == username.ToLower() && x.Password == password);

            if (user == null)
            {
                return null;
            }

            var userRoles = await studentDetailsDbContext.Users_Roles.Where(x => x.UserId == user.Id).ToListAsync();

            if (userRoles.Any())
            {
                user.Roles = new List<string>();
                foreach (var userRole in userRoles)
                {
                    var role = await studentDetailsDbContext.Roles.FirstOrDefaultAsync(x => x.Id == userRole.RoleId);
                    if (role != null)
                    {
                        user.Roles.Add(role.Name);
                    }
                }
            }

            user.Password = null;
            return user;
        }

       
    }
}
