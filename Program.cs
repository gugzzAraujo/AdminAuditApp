using AdminAuditApp.Models;
using AdminAuditApp.Services;

Console.WriteLine("start system...");

UserService userService = new UserService();

User usuarioInvalido = new User()
{
    Id = 1,
    Name = "",
    Email = "Gustavo@email",
    Age = 20,
    IsActive = true
};
Console.WriteLine("Adding user...");

userService.AddUser(usuarioInvalido);

Console.WriteLine("Sucess!");

