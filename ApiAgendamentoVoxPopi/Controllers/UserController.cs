using ApiAgendamentoVoxPopi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAgendamentoVoxPopi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<User>> BuscarUsuarios()
        {
            return Ok("Usuário");
        }
    }
}
