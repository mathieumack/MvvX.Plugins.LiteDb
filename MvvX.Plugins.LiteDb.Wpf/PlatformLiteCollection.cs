using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using LiteDB;
using MvvX.Plugins.LiteDb;

namespace MvvX.Plugins.LiteDb.Wpf
{
    public class PlatformLiteCollection<T> : ILiteCollection<T> 
        where T : new()
    {
        private readonly LiteCollection<T> collection;

        public PlatformLiteCollection(LiteCollection<T> collection)
        {
            this.collection = collection;
        }

        public string Name
        {
            get
            {
                return collection.Name;
            }
        }

        public int Count()
        {
            return collection.Count();
        }

        public int Count(Expression<Func<T, bool>> predicate)
        {
            return collection.Count(predicate);
        }

        public int Delete(Expression<Func<T, bool>> predicate)
        {
            return collection.Delete(predicate);
        }

        public bool DropIndex(string field)
        {
            return collection.DropIndex(field);
        }

        public bool EnsureIndex(string field, bool unique = false)
        {
            return collection.EnsureIndex(field, unique);
        }

        public bool EnsureIndex<K>(Expression<Func<T, K>> property, bool unique = false)
        {
            return collection.EnsureIndex<K>(property, unique);
        }

        public bool Exists(Expression<Func<T, bool>> predicate)
        {
            return collection.Exists(predicate);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate, int skip = 0, int limit = int.MaxValue)
        {
            return collection.Find(predicate, skip, limit);
        }

        public IEnumerable<T> FindAll()
        {
            return collection.FindAll();
        }

        //public T FindOne(IQuery query)
        //{
        //    return collection.FindOne(query);
        //}

        public T FindOne(Expression<Func<T, bool>> predicate)
        {
            return collection.FindOne(predicate);
        }

        public ILiteCollection<T> Include<K>(Expression<Func<T, K>> dbref)
        {
            var result = collection.Include<K>(dbref);
            return new PlatformLiteCollection<T>(result);
        }

        public IBsonValue Insert(T document)
        {
            return new PlatformBsonValue(collection.Insert(document));
        }

        public int Insert(IEnumerable<T> docs)
        {
            return collection.Insert(docs);
        }

        public long LongCount()
        {
            return collection.LongCount();
        }

        public long LongCount(Expression<Func<T, bool>> predicate)
        {
            return collection.LongCount(predicate);
        }

        public IBsonValue Max()
        {
            return new PlatformBsonValue(collection.Max());
        }

        public IBsonValue Max(string field)
        {
            return new PlatformBsonValue(collection.Max(field));
        }

        public IBsonValue Max<K>(Expression<Func<T, K>> property)
        {
            return new PlatformBsonValue(collection.Max<K>(property));
        }

        public IBsonValue Min()
        {
            return new PlatformBsonValue(collection.Min());
        }

        public IBsonValue Min(string field)
        {
            return new PlatformBsonValue(collection.Min());
        }

        public IBsonValue Min<K>(Expression<Func<T, K>> property)
        {
            return new PlatformBsonValue(collection.Min<K>(property));
        }

        public bool Update(T document)
        {
            return collection.Update(document);
        }

        public int Update(IEnumerable<T> documents)
        {
            return collection.Update(documents);
        }

        //public bool Update(IBsonValue id, T document)
        //{
        //    return collection.Update(id, document);
        //}
    }
}
