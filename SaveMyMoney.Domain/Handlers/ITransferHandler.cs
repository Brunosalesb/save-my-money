using SaveMyMoney.Domain.Commands.Requests.Transfers;
using SaveMyMoney.Domain.Commands.Responses.Transfers;

namespace SaveMyMoney.Domain.Handlers
{
    public interface ITransferHandler
    {
        RegisterTransferResponse Post(RegisterTransferRequest req);
        GetTransferResponse GetById(int id);
    }
}
