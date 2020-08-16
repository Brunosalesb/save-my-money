using SaveMyMoney.Domain.Entities;
using System;
using System.Collections.Generic;

namespace SaveMyMoney.Domain.Commands.Responses.Transfers
{
    public class GetTransferResponse
    {
        public GetTransferResponse(Transfer transfer)
        {
            Id = transfer.Id;
            Value = transfer.Value;
            TransferDate = transfer.TransferDate;
            RegisterDate = transfer.RegisterDate;
            TransferType = transfer.TransferType.ToString();
        }

        public int Id { get; set; }
        public decimal Value { get; set; }
        public DateTime? TransferDate { get; set; }
        public DateTime RegisterDate { get; private set; }
        public string TransferType { get; set; }
    }
}
