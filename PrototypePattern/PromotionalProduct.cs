using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypePattern
{
    public class PromotionalProduct : ICloneable
    {
        public int Price { get; set; }
        public int PromotionPercentage { get; set; }
        public User User { get; set; }

        public object Clone()
        {
            var clone = MemberwiseClone() as PromotionalProduct;
            clone.User = User.Clone() as User;
            return clone;
        }
    }
}
