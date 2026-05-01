using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminAuditApp.Models;

namespace AdminAuditApp.Services
{
    public class UserService
    {
       private List<User> _users = new List<User>();


        public void AddUser(User user)
        {
            if(user.Age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            if(string.IsNullOrWhiteSpace(user.Name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                throw new ArgumentException("Email cannot be null or empty");
            }
            if(_users.Any(u => u.Email == user.Email))
            {
                throw new ArgumentException("Email already exists.");
            }
            if (!user.Email.Contains("@"))
            {
                throw new ArgumentException("Invalid email format");
            }
            
            _users.Add(user);
        }
    }


}
