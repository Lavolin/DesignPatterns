namespace CompositePatternII
{
    public class SingleGift : GiftBase
    {
        public SingleGift(int price, string name) : base(price, name)
        {
        }

        public override int CalculateTotalPrice()
            => this.price;
    }
}
