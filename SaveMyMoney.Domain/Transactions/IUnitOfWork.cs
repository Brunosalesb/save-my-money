namespace SaveMyMoney.Domain.Transactions
{
    public interface IUnitOfWork
    {
        void Commit();
        void Rollback();
    }
}
