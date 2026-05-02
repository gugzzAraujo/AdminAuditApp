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


        public ResultadoOperacao AddUser(User user)
        {
            if(user.Age < 0)
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "Age cannot be negative"
                };
            }
            if(string.IsNullOrWhiteSpace(user.Name))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "Name cannot be null or empty"
                };
            }
            if (string.IsNullOrWhiteSpace(user.Email))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "Email cannot be null or empty"
                };
            }
            if (!user.Email.Contains("@"))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "Invalid email format."
                };
            }
            if (_users.Any(u => u.Email == user.Email))
            {
                return new ResultadoOperacao 
                { 
                    Sucesso = false,
                    MensagemErro = "Email already exists." 
                };
            }
            _users.Add(user);

            return new ResultadoOperacao
            {
                Sucesso = true,
                MensagemErro = ""
            };
        }

        public ResultadoOperacao GetUserByEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "Search Email cannot be null or empty."
                };
            }

            var user = _users.FirstOrDefault(u => u.Email == email);
            if(user == null)
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "User not found."
                };
            }

            return new ResultadoOperacao
            {
                Sucesso = true,
                MensagemErro = "",
                Dados = user
            };
        }
    }
}
