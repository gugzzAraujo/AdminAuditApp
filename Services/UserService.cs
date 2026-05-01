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
       private List<User> _user = new List<User>();


        public string AddUser(User user)
        {
            if(user.Age < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            if(string.IsNullOrWhiteSpace(user.Name))
            {
                throw new ArgumentException("Name cannot be null or empty");
            }
            _user.Add(user);
        }
    }


}
