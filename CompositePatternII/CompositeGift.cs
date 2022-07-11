using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternII
{
    public class CompositeGift : GiftBase, IGiftOperations
    {
        private readonly List<GiftBase> giftBases;
        public CompositeGift(int price, string name) : base(price, name)
        {
            this.giftBases = new List<GiftBase>();
        }

        public void Add(GiftBase giftBase)
            => this.giftBases.Add(giftBase);

        public override int CalculateTotalPrice()
            => this.giftBases.Sum(x => x.CalculateTotalPrice());

        public void Remove(GiftBase giftBase)
            => this.giftBases.Remove(giftBase);
    }
}
