using SaveMyMoney.Domain.Enums;
using System;

namespace SaveMyMoney.Domain.Entities
{
    public class Transfer
    {
        protected Transfer() { }
        public Transfer(decimal value, int userId, DateTime? transferDate)
        {
            Value = value;
            UserId = userId;
            TransferDate = transferDate;
            RegisterDate = DateTime.Now;
            TransferType = Value >= 0 ? ETransferType.Profit : ETransferType.Loss;
        }

        public int Id { get; private set; }
        public decimal Value { get; private set; }
        public DateTime? TransferDate { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public ETransferType TransferType { get; private set; }
        public int UserId { get; private set; }
        public User User { get; private set; }
    }
}
