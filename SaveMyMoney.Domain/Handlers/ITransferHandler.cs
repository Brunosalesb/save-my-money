﻿using SaveMyMoney.Domain.Commands.Requests.Transfers;
using SaveMyMoney.Domain.Commands.Responses.Transfers;
using System.Collections.Generic;

namespace SaveMyMoney.Domain.Handlers
{
    public interface ITransferHandler
    {
        RegisterTransferResponse Post(RegisterTransferRequest req);
        GetTransferResponse GetById(int id);
    }
}
