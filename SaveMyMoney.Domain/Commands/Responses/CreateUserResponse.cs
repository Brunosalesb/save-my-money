using System;
using System.Collections.Generic;
using System.Text;

namespace SaveMyMoney.Domain.Commands.Responses
{
    public class CreateUserResponse
    {
        public CreateUserResponse()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
