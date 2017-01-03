using System.Collections.Generic;

namespace MvvX.Plugins.LiteDb
{
    public interface ILiteDatabase
    {
        int PAGE_SIZE { get; }
        
        ushort DbVersion { get; set; }
        //public LiteFileStorage FileStorage { get; }
        //public Logger Log { get; }
        //public BsonMapper Mapper { get; }

        //LiteTransaction BeginTrans();
        bool CollectionExists(string name);
        //void Dispose();
        bool DropCollection(string name);
        //ILiteCollection<BsonDocument> GetCollection(string name);
        ILiteCollection<T> GetCollection<T>(string name) where T : new();
        IEnumerable<string> GetCollectionNames();
        bool RenameCollection(string oldName, string newName);
        //public BsonValue Run(string command);
        //public BsonValue Run(string command, params BsonValue[] args);
        long Shrink();
        //BsonDocument ToDocument(Type type, object entity);
        //BsonDocument ToDocument<T>(T entity);
        //object ToObject(Type type, BsonDocument doc);
        //T ToObject<T>(BsonDocument doc) where T : new();
    }
}
