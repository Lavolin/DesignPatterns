using System;

namespace TemplatePattern
{
    public abstract class Bread
    {

        public abstract void Mix();

        public abstract void Bake();
        public virtual void Slice()
        {
            Console.WriteLine($"Slicing {this.GetType().Name}");
        }

        public void Make()
        {
            this.Mix();
            this.Bake();
            this.Slice();

            Console.WriteLine("Done");
        }
    }
}
