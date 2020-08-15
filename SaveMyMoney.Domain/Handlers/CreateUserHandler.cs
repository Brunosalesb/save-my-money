using SaveMyMoney.Domain.Commands.Requests;
using SaveMyMoney.Domain.Commands.Responses;
using SaveMyMoney.Domain.Entities;
using SaveMyMoney.Domain.Repos;
using SaveMyMoney.Domain.Transactions;
using SaveMyMoney.Domain.ValueObjects;
using System;

namespace SaveMyMoney.Domain.Handlers
{
    public class CreateUserHandler : ICreateUserHandler
    {
        private readonly IUserRepo _repo;
        private readonly IUnitOfWork _unitOfWork;

        public CreateUserHandler(IUserRepo repo, IUnitOfWork unitOfWork)
        {
            _repo = repo;
            _unitOfWork = unitOfWork;
        }

        public CreateUserResponse Handle(CreateUserRequest req)
        {
            var name = new Name(req.FirstName, req.LastName);
            var user = new User(req.Email, name, req.Password);

            _repo.CreateUser(user);

            _unitOfWork.Commit();

            return new CreateUserResponse();
        }
    }
}
