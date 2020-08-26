using SaveMyMoney.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace SaveMyMoney.Domain.Entities
{
    public class User
    {
        protected User() { }
        public User(string email, Name name, string password)
        {
            Email = email;
            Name = name;
            Password = password;
            RegisterDate = DateTime.Now;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public Name Name { get; private set; }
        public string Password { get; private set; }
        public DateTime RegisterDate { get; private set; }

        public List<Transfer> Transfer { get; private set; }
        public Wallet Wallet { get; private set; }
    }
}
