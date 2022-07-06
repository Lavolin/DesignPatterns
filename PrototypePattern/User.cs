using System;

namespace PrototypePattern
{
    public class User : ICloneable
    {
        public string Name { get; internal set; }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}