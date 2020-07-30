using System.Transactions;

namespace RbarExample.DataAccess
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;

        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Commit()
        {
            using (var scope = new TransactionScope())
            {
                _dataContext.SaveChanges();
                scope.Complete();
            }
        }
    }
}
