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
            if (!user.Email.Contains("@"))
            {
                return new ResultadoOperacao
                {
                    Sucesso = false,
                    MensagemErro = "Invalid email format"
                };
            }
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
            if(_users.Any(u => u.Email == user.Email))
            {
                return new ResultadoOperacao 
                { 
                    Sucesso = false,
                    MensagemErro = "Email already exists." 
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
            
            _users.Add(user);

            return new ResultadoOperacao
            {
                Sucesso = true,
                MensagemErro = ""
            };
        }
    }
}
