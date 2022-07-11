using System;

namespace TemplatePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bread wholeWheat = new WholeWheat();
            Bread sourdough = new Sourdough();

            wholeWheat.Make();
            sourdough.Make();
        }
    }
}
