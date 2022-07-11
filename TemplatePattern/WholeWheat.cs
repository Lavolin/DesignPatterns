using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class WholeWheat : Bread
    {
        public override void Bake()
        {
            Console.WriteLine("Baking WholeWheat");
        }

        public override void Mix()
        {
            Console.WriteLine("Mixing WholeWheat");

        }
    }
}
