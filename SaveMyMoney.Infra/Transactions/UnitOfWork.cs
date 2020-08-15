using SaveMyMoney.Domain.Transactions;
using SaveMyMoney.Infra.Contexts;

namespace SaveMyMoney.Infra.Transactions
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            //do nothing, the transaction will die by EF
        }
    }
}
