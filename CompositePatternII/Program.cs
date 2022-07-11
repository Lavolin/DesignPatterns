using System;

namespace CompositePatternII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleGift toy = new SingleGift(15, "toy");
            SingleGift car = new SingleGift(20, "car");

            var compositeGift = new CompositeGift(0, "Composite gift");
            compositeGift.Add(toy);
            compositeGift.Add(car);

            var compositeGift2= new CompositeGift(0, "Composite gift");
            compositeGift2.Add(car);

            compositeGift.Add(compositeGift2);

            Console.WriteLine(compositeGift.CalculateTotalPrice());
        }
    }
}
