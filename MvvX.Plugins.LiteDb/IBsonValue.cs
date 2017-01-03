using System;

namespace MvvX.Plugins.LiteDb
{
    public interface IBsonValue
    {
        byte[] AsBinary { get; }
        bool AsBoolean { get; }
        DateTime AsDateTime { get; }
        //BsonDocument AsDocument { get; }
        double AsDouble { get; }
        Guid AsGuid { get; }
        int AsInt32 { get; }
        long AsInt64 { get; }
        //ObjectId AsObjectId { get; }
        string AsString { get; }
        bool IsArray { get; }
        bool IsBinary { get; }
        bool IsBoolean { get; }
        bool IsDateTime { get; }
        bool IsDocument { get; }
        bool IsDouble { get; }
        bool IsGuid { get; }
        bool IsInt32 { get; }
        bool IsInt64 { get; }
        bool IsMaxValue { get; }
        bool IsMinValue { get; }
        bool IsNull { get; }
        bool IsNumber { get; }
        bool IsObjectId { get; }
        bool IsString { get; }
        object RawValue { get; }
        //BsonType Type { get; }

        //int CompareTo(IBsonValue other);
        //bool Equals(IBsonValue other);
        //override bool Equals(object obj);
        int GetBytesCount(bool recalc);
    }
}