using Microsoft.AspNetCore.Mvc;
using SaveMyMoney.Api.Services;
using SaveMyMoney.Domain.Commands.Requests;
using SaveMyMoney.Domain.Repos;

namespace SaveMyMoney.Api.Controllers
{
    [ApiController]
    [Route("login")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepo _repo;
        public UserController(IUserRepo repo)
        {
            _repo = repo;
        }

        [HttpPost]
        public IActionResult Authenticate([FromBody]AuthenticateUserRequest req)
        {
            var user = _repo.Get(req.Email, req.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);

            return Ok(new { user = user.Name.ToString(), token = token });
        }
    }
}
