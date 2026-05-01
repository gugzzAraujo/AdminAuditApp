using AdminAuditApp.Models;
using AdminAuditApp.Services;

Console.WriteLine("start system...");

UserService userService = new UserService();

User usuarioInvalido = new User()
{
    Id = 1,
    Name = "Guga",
    Email = "Pereba@gmail.com",
    Age = 20,
    IsActive = true
};
User usuarioInvalido2 = new User()
{
    Id = 2,
    Name = "Hylander",
    Email = "Pereba@gmail.com",
    Age = 20,
    IsActive = true
};

Console.WriteLine("Adding user...");

userService.AddUser(usuarioInvalido);
userService.AddUser(usuarioInvalido2);

Console.WriteLine("Sucess!");

