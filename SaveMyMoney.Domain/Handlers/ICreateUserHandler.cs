using SaveMyMoney.Domain.Commands.Requests;
using SaveMyMoney.Domain.Commands.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace SaveMyMoney.Domain.Handlers
{
    public interface ICreateUserHandler
    {
        CreateUserResponse Handle(CreateUserRequest req);
    }
}
