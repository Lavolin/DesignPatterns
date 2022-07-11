using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class Sourdough : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking Sourdough");
        }

        public override void Mix()
        {
            Console.WriteLine("Mixing Sourdough");

        }
    }
}
