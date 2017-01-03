using LiteDB;
using System;
using System.Collections.Generic;

namespace MvvX.Plugins.LiteDb.Wpf
{
    public class PlatformLiteDatabase : ILiteDatabase, IDisposable
    {
        private LiteDatabase liteDatabase;

        public void Construct(string connectionString)
        {
            liteDatabase = new LiteDatabase(connectionString);
        }

        public ushort DbVersion
        {
            get
            {
                return liteDatabase.DbVersion;
            }

            set
            {
                liteDatabase.DbVersion = value;
            }
        }

        public int PAGE_SIZE
        {
            get
            {
                return LiteDatabase.PAGE_SIZE;
            }
        }

        public ILiteTransaction BeginTrans()
        {
            var trans = liteDatabase.BeginTrans();
            return new PlatformLiteTransaction(trans);
        }

        public bool CollectionExists(string name)
        {
            return liteDatabase.CollectionExists(name);
        }

        public void Dispose()
        {
            if (liteDatabase != null)
                liteDatabase.Dispose();
        }

        public bool DropCollection(string name)
        {
            return liteDatabase.DropCollection(name);
        }

        public ILiteCollection<T> GetCollection<T>(string name) where T : new()
        {
            var result = liteDatabase.GetCollection<T>(name);
            return new PlatformLiteCollection<T>(result);
        }

        public IEnumerable<string> GetCollectionNames()
        {
            return liteDatabase.GetCollectionNames();
        }

        public bool RenameCollection(string oldName, string newName)
        {
            return liteDatabase.RenameCollection(oldName, newName);
        }

        public long Shrink()
        {
            return liteDatabase.Shrink();
        }
    }
}
