using AdminAuditApi.Services;
using Microsoft.AspNetCore.Mvc;
using AdminAuditApi.Models;

namespace AdminAuditApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }
        [HttpPost("Adicionar")]
        public IActionResult AddUser([FromBody] User user)
        {
            var resultado = _userService.AddUser(user);
            if (!resultado.Sucesso)
            {
                return BadRequest(resultado);
            }
            return Ok(resultado.Dados);
        }

        [HttpGet("buscar/{email}")]
        public IActionResult GetUser(string email)
        {
            var resultado = _userService.GetUserByEmail(email);

            if (!resultado.Sucesso)
                return NotFound(resultado);

            return Ok(resultado);
        }
        [HttpPut("atualizar/{email}")]
        public IActionResult UpdateUser(string email, [FromBody] User novosDados)
        {
            var resultado = _userService.UpdateUser(email, novosDados);

            if (!resultado.Sucesso)
                return BadRequest(resultado);

            return Ok(resultado);
        }

    }
}
