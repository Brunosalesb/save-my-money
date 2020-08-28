using SaveMyMoney.Domain.Commands.Requests.Transfers;
using SaveMyMoney.Domain.Commands.Responses.Transfers;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Domain.Repos;
using SaveMyMoney.Domain.Transactions;
using System.Collections.Generic;
using System.Linq;

namespace SaveMyMoney.Domain.Handlers
{
    public class TransferHandler : ITransferHandler
    {
        private readonly ITransferRepo _repo;
        private readonly IUnitOfWork _unitOfWork;

        public TransferHandler(ITransferRepo repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public void Delete(int id)
        {
            var transfer = _repo.GetById(id);
            if (transfer == null)
                return;

            _repo.Delete(transfer);

            _unitOfWork.Commit();
        }

        public ICollection<GetTransferResponse> GetAll()
        {
            var transfer = _repo.GetAll().Select(x => new GetTransferResponse(x)).ToList();

            return transfer;
        }

        public GetTransferResponse GetById(int id)
        {
            var transfer = _repo.GetById(id);

            return new GetTransferResponse(transfer);
        }

        public RegisterTransferResponse Post(RegisterTransferRequest req)
        {
            var transfer = new Transfer(req.Value, req.TransferDate);

            _repo.Save(transfer);

            _unitOfWork.Commit();

            return new RegisterTransferResponse(transfer);
        }

        public void Update(UpdateTransferRequest req)
        {
            var transfer = _repo.GetById(req.Id);
            if (transfer == null)
                return;

            transfer.Update(req);

            _repo.Update(transfer);

            _unitOfWork.Commit();
        }
    }
}
