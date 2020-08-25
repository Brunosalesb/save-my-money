namespace SaveMyMoney.Domain.Commands.Requests.Transfers
{
    public class UpdateTransferRequest : RegisterTransferRequest
    {
        public int Id { get; set; }
    }
}
