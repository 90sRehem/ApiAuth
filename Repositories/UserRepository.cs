using ApiAuth.Models;

namespace ApiAuth.Repositories
{
    public class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>
            {
                new() { Id = 1, UserName = "john doe", Password = "secretpassword", Role = "manager"},
                new() { Id = 1, UserName = "jane doe", Password = "anothersecretpassword", Role = "employee" },
            };

            return users
                .FirstOrDefault(x =>
                    string.Equals(x.UserName, username, StringComparison.CurrentCultureIgnoreCase) &&
                    x.Password == password
                );
        }
    }
}