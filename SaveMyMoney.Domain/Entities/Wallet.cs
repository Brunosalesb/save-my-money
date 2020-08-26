using System.Collections.Generic;

namespace SaveMyMoney.Domain.Entities
{
    public class Wallet
    {
        protected Wallet() { }

        public int Id { get; private set; }
        public decimal Balance { get; private set; }
        public int UserId { get; private set; }

        public User User { get; private set; }
        //public List<Transfer> Transfer { get; private set; }

    }
}
