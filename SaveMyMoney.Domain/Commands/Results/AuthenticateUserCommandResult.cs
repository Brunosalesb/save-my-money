using SaveMyMoney.Domain.ValueObjects;
using SaveMyMoney.Shared.Commands;

namespace SaveMyMoney.Domain.Commands.Results
{
    public class AuthenticateUserCommandResult : ICommandResult
    {
        public AuthenticateUserCommandResult()
        {

        }

        public AuthenticateUserCommandResult(int id, string email, Name name, string token)
        {
            Id = id;
            Email = email;
            Name = name;
            Token = token;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public Name Name { get; set; }
        public string Token { get; set; }

    }
}
