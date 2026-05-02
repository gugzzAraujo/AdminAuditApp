using AdminAuditApp.Models;
using AdminAuditApp.Services;

Console.WriteLine("start system...");

UserService userService = new UserService();

User usuarioInvalido = new User()
{
    Id = 1,
    Name = "Guga",
    Email = "Gustavo@gmail.com",
    Age = 18,
    IsActive = true
};
User usuarioInvalido2 = new User()
{
    Id = 2,
    Name = "Hylander",
    Email = "Guga@gmail.ocm",
    Age = 19,
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

var resultadoBusca = userService.GetUserByEmail("Gustavo@gmail.com");
if (resultadoBusca.Sucesso)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"User found: {resultadoBusca.Dados.Name}, Age: {resultadoBusca.Dados.Age}");
    Console.ResetColor();
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[ERROR] {resultadoBusca.MensagemErro}");
    Console.ResetColor();
}

User novosDados = new User { Name = "Gusttavo Silva Araujo", Email = "Guga@gmail.com", Age = 19 };

var resultadoUpdate = userService.UpdateUser("Gustavo@gmail.com", novosDados);

if (resultadoUpdate.Sucesso)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("User updated successfully!");
    Console.ResetColor();

    var buscaConfirmacao = userService.GetUserByEmail("Guga@gmail.com");
    Console.WriteLine($"Prova Real -> Nome novo é: {buscaConfirmacao.Dados.Name} | Idade nova é: {buscaConfirmacao.Dados.Age}");
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[ERROR] {resultadoUpdate.MensagemErro}");
    Console.ResetColor();
}
    Console.WriteLine("End");

