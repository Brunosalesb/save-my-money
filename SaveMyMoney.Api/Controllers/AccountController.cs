using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaveMyMoney.Api.Services;
using SaveMyMoney.Domain.Commands.Inputs;
using SaveMyMoney.Domain.Repos;
using SaveMyMoney.Infra.Repos;
using System.Threading.Tasks;

namespace SaveMyMoney.Api.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserRepo _repo;
        public AccountController(IUserRepo repo)
        {
            _repo = repo;
        }
        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public ActionResult AuthenticateUser(AuthenticateUserCommand cmd)
        {
            var user = _repo.Get("bruno.sbernardes@gmail.com", "123");

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            
            return Ok(token);
        }
    }
}
