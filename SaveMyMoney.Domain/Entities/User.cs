using SaveMyMoney.Domain.ValueObjects;
using System;

namespace SaveMyMoney.Domain.Entities
{
    public class User
    {
        #region Constructors
        protected User() { }
        public User(string email, Name name, string password)
        {
            Email = email;
            Name = name;
            Password = password;
            RegisterDate = DateTime.Now;
        }
        #endregion

        #region Properties
        public int Id { get; private set; }
        public string Email { get; private set; }
        public Name Name { get; private set; }
        public string Password { get; private set; }
        public DateTime RegisterDate { get; private set; }

        public virtual Wallet Wallet { get; private set; }
        #endregion
    }
}
