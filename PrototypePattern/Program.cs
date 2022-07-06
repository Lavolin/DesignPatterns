using System;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PromotionalProduct prototype = new PromotionalProduct();
            prototype.Price = 5;
            prototype.PromotionPercentage = 30;
            User user = new User();
            user.Name = "Toshko";
            prototype.User = user;

            PromotionalProduct clonePrototype = prototype.Clone() as PromotionalProduct;

            clonePrototype.PromotionPercentage = 50;
            clonePrototype.User.Name = "Heni";
            Console.WriteLine(clonePrototype.PromotionPercentage);
            Console.WriteLine(clonePrototype.User.Name);

            Console.WriteLine(prototype.PromotionPercentage);
            Console.WriteLine(prototype.User.Name);
        }
    }
}
