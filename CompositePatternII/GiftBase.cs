using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePatternII
{
    public abstract class GiftBase
    {
        protected int price;
        protected string name;

        protected GiftBase(int price, string name)
        {
            this.price = price;
            this.name = name;
        }

        public abstract int CalculateTotalPrice();
        
    }
}
