using System.Collections.Generic;

namespace SaveMyMoney.Domain.Entities
{
    public class Wallet
    {
        #region Constructors
        protected Wallet() { }
        #endregion

        #region Properties
        public int Id { get; private set; }
        public decimal Balance { get; private set; }
        public int UserId { get; private set; }

        public virtual User User { get; private set; }
        public virtual ICollection<Transfer> Transfers { get; private set; }
        #endregion
    }
}
