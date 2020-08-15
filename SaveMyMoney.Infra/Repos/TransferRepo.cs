using SaveMyMoney.Domain.Commands.Responses;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Domain.Repos;
using SaveMyMoney.Infra.Contexts;

namespace SaveMyMoney.Infra.Repos
{
    public class TransferRepo : ITransferRepo
    {
        private readonly DataContext _context;

        public TransferRepo(DataContext context)
        {
            _context = context;
        }

        public Transfer GetById(int id)
        {
            return _context.Transfers.Find(id);
        }

        public void Save(Transfer transfer)
        {
            _context.Transfers.Add(transfer);
        }
    }
}
