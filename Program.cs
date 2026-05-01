using AdminAuditApp.Models;
using AdminAuditApp.Services;

Console.WriteLine("start system...");

UserService userService = new UserService();

User usuarioInvalido = new User()
{
    Id = 1,
    Name = "Guga",
    Email = "Gustavo@gmail.com",
    Age = -1,
    IsActive = true
};
User usuarioInvalido2 = new User()
{
    Id = 2,
    Name = "Hylander",
    Email = "Guga@gmail.ocm",
    Age = -10,
    IsActive = true
};

Console.WriteLine("Adding user...");

ResultadoOperacao resultado1 = userService.AddUser(usuarioInvalido);

if (!resultado1.Sucesso)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[ERROR] {resultado1.MensagemErro}\n");
    Console.ResetColor(); 
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("User added successfully!\n");
    Console.ResetColor();
}
Console.WriteLine("Adding user 2...");

ResultadoOperacao resultado2 = userService.AddUser(usuarioInvalido2);

if(!resultado2.Sucesso)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[ERROR] {resultado2.MensagemErro}\n");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("User added successfully!\n");
    Console.ResetColor();
}
    

Console.WriteLine("End");

