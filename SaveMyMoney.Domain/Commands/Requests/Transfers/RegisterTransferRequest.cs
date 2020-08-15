using System;

namespace SaveMyMoney.Domain.Commands.Requests.Transfers
{
    public class RegisterTransferRequest
    {
        public decimal Value { get; set; }
        public DateTime? TransferDate { get; set; }
    }
}
