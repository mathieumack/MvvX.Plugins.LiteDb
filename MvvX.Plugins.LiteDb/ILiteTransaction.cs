using System;

namespace MvvX.Plugins.LiteDb
{
    public interface ILiteTransaction : IDisposable
    {
        TransactionState State { get; }

        void Commit();

        void Rollback();
    }
}
