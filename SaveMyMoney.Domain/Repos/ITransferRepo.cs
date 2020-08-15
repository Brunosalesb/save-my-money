using SaveMyMoney.Domain.Commands.Responses;
using SaveMyMoney.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveMyMoney.Domain.Repos
{
    public interface ITransferRepo
    {
        void Save(Transfer transfer);
        Transfer GetById(int id);
    }
}
