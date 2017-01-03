using LiteDB;

namespace MvvX.Plugins.LiteDb.Wpf
{
    public class PlatformLiteTransaction : ILiteTransaction
    {
        private readonly LiteTransaction liteTransaction;

        public PlatformLiteTransaction(LiteTransaction liteTransaction)
        {
            this.liteTransaction = liteTransaction;
        }

        public TransactionState State
        {
            get
            {
                return (TransactionState)(int)liteTransaction.State;
            }
        }

        public void Commit()
        {
            liteTransaction.Commit();
        }

        public void Dispose()
        {
            if (liteTransaction != null)
                liteTransaction.Dispose();
        }

        public void Rollback()
        {
            liteTransaction.Rollback();
        }
    }
}
