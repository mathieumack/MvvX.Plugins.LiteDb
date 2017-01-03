using LiteDB;
using System;

namespace MvvX.Plugins.LiteDb.Wpf
{
    public class PlatformLiteDatabase : LiteDatabase, ILiteDatabase, IDisposable
    {
        /// <summary>
        /// Create a new connection to a database
        /// </summary>
        /// <param name="connectionString"></param>
        public PlatformLiteDatabase(string connectionString)
            : base(connectionString)
        {
        }
        
        public int PAGE_SIZE
        {
            get
            {
                return LiteDatabase.PAGE_SIZE;
            }
        }

        public ILiteCollection<T> GetCollection<T>(string name) where T : new()
        {
            var result = base.GetCollection<T>(name);
            return new PlatformLiteCollection<T>(result);
        }
    }
}
