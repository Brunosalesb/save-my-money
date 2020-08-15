using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Domain.Repos;
using SaveMyMoney.Infra.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SaveMyMoney.Infra.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly SaveMyMoneyDataContext _context;
        public UserRepo(SaveMyMoneyDataContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);
        }

        public User Get(string email, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email && x.Password == password);
        }
    }
}
