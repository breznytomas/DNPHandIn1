using Models;

namespace HandIn1.Data
{
    public interface IUserSecurity
    {
        public User ValidateUser(string UserName, string Password);
    }
}