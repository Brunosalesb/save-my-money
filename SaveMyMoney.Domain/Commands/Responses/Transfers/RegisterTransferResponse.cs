using SaveMyMoney.Domain.Entities;
using System;

namespace SaveMyMoney.Domain.Commands.Responses.Transfers
{
    public class RegisterTransferResponse
    {
        public RegisterTransferResponse(Transfer transfer)
        {
            Id = transfer.Id;
            Value = transfer.Value;
            TransferDate = transfer.TransferDate;
            TransferType = transfer.TransferType.ToString();
        }

        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime? TransferDate { get; set; }
        public string TransferType { get; set; }
    }
}
