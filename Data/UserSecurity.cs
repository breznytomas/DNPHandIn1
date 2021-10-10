using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace HandIn1.Data
{
    public class UserSecurity : IUserSecurity
    {
        
        private List<User> users;

        public UserSecurity()
        {
            users = new[]
            {
                new User()
                {
                    Username = "Tomas",
                    Password = "Tomas",
                    CredentialLevel = 1
                }
            }.ToList();
        }

       
          


        public User ValidateUser(string userName, string password) {
            User first = users.FirstOrDefault(user => user.Username.Equals(userName));
            if (first == null) {
                throw new Exception("User not found");
            }

            if (!first.Password.Equals(password)) {
                throw new Exception("Incorrect password");
            }

            return first;
        }
        
        
       
    }
}