using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MvvX.Plugins.LiteDb
{
    public interface ILiteCollection<T> 
        where T : new()
    {
        string Name { get; }

        int Count();
        int Count(Expression<Func<T, bool>> predicate);
        //int Count(Query query);
        int Delete(Expression<Func<T, bool>> predicate);
        //bool Delete(BsonValue id);
        //int Delete(Query query);
        bool DropIndex(string field);
        bool EnsureIndex(string field, bool unique = false);
        //bool EnsureIndex(string field, IndexOptions options);
        bool EnsureIndex<K>(Expression<Func<T, K>> property, bool unique = false);
        //bool EnsureIndex<K>(Expression<Func<T, K>> property, IndexOptions options);
        bool Exists(Expression<Func<T, bool>> predicate);
        //bool Exists(Query query);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate, int skip = 0, int limit = int.MaxValue);
        //IEnumerable<T> Find(Query query, int skip = 0, int limit = int.MaxValue);
        IEnumerable<T> FindAll();
        //T FindById(BsonValue id);
        T FindOne(Expression<Func<T, bool>> predicate);
        //T FindOne(IQuery query);
        //CollectionInfo GetCollectionInfo();
        //IEnumerable<IndexInfo> GetIndexes(bool includeStats = false);
        ILiteCollection<T> Include<K>(Expression<Func<T, K>> dbref);
        int Insert(IEnumerable<T> docs);
        IBsonValue Insert(T document);
        long LongCount();
        long LongCount(Expression<Func<T, bool>> predicate);
        //long LongCount(Query query);
        IBsonValue Max();
        IBsonValue Max(string field);
        IBsonValue Max<K>(Expression<Func<T, K>> property);
        IBsonValue Min();
        IBsonValue Min(string field);
        IBsonValue Min<K>(Expression<Func<T, K>> property);
        int Update(IEnumerable<T> documents);
        bool Update(T document);
        bool Update<Y>(Y id, T document) where Y : IBsonValue;
    }
}