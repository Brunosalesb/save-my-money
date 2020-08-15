using SaveMyMoney.Shared.Commands;

namespace SaveMyMoney.Domain.Commands.Inputs
{
    public class AuthenticateUserCommand : ICommand
    {
        public AuthenticateUserCommand()
        {

        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
