using Microsoft.AspNetCore.Mvc;
using SaveMyMoney.Api.Services;
using SaveMyMoney.Domain.Commands.Requests;
using SaveMyMoney.Domain.Handlers;
using SaveMyMoney.Domain.Repos;
using System.Text;

namespace SaveMyMoney.Api.Controllers
{
    [ApiController]
    [Route("user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        private readonly ICreateUserHandler _handle;
        public UserController(IUserRepo repo, ICreateUserHandler handle)
        {
            _repo = repo;
            _handle = handle;
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Authenticate([FromBody]AuthenticateUserRequest req)
        {
            var user = _repo.Get(req.Email, req.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            return Ok(new { user = user.Name.ToString(), token = token });
        }

        [Route("teste")]
        [HttpPost]
        public IActionResult Teste([FromBody] CreateUserRequest req)
        {
            var response = _handle.Handle(req);
            return Ok(response);
        }
    }
}
