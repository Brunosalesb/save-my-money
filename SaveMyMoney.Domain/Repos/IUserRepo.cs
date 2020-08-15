using SaveMyMoney.Domain.Entities;

namespace SaveMyMoney.Domain.Repos
{
    public interface IUserRepo
    {
        User Get(string email, string password);
        void CreateUser(User user);
    }
}
