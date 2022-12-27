using Student.Models.Domain;

namespace Student.Repositories
{
    public class StaticUserRepository : IUserRepository
    {
        private List<User> Users = new List<User>()
        {
            //new User()
            //{
            //    FirstName = "Read Only", LastName = "User", EmailAddress = "readonly@user.com",
            //    Username = "read", Password = "Read",
            //    Roles = new List<string> { "reader" }
            //},
            //new User()
            //{
            //    FirstName = "Read Write", LastName = "User", EmailAddress = "readwrite@user.com",
            //    Username = "readwrite@user.com", Password = "Readwrite@user",
            //    Roles = new List<string> { "reader", "writer" }
            //}
        };



        public async Task<User> AuthenticateAsync(string username, string password)
        {
            var user = Users.Find(x => x.Username.Equals(username, StringComparison.InvariantCultureIgnoreCase) &&
            x.Password == password);

            return user;
        }
    }
    
}
