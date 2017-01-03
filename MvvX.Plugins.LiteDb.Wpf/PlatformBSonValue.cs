using LiteDB;
using System;
using System.Collections.Generic;

namespace MvvX.Plugins.LiteDb.Wpf
{
    public class PlatformBsonValue : BsonValue, IBsonValue
    {
        public PlatformBsonValue()
            : base()
        { }

        public PlatformBsonValue(DateTime value)
            : base(value)
        { }
        public PlatformBsonValue(bool value)
            : base(value)
        { }
        public PlatformBsonValue(Guid value)
            : base(value)
        { }
        public PlatformBsonValue(ObjectId value)
            : base(value)
        { }
        public PlatformBsonValue(byte[] value)
            : base(value)
        { }
        public PlatformBsonValue(string value)
            : base(value)
        { }
        public PlatformBsonValue(Dictionary<string, BsonValue> value)
            : base(value)
        { }
        public PlatformBsonValue(BsonValue value)
            : base(value)
        { }
        public PlatformBsonValue(double value)
            : base(value)
        { }
        public PlatformBsonValue(long value)
            : base(value)
        { }
        public PlatformBsonValue(int value)
            : base(value)
        { }
        public PlatformBsonValue(List<BsonValue> value)
            : base(value)
        { }
        public PlatformBsonValue(object value)
            : base(value)
        { }
    }
}