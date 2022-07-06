using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Shapes
{
    class Character : CompositeElement
    {
        public Character(int size, char @char) : base(size, @char)
        {
        }

        public override void Draw()
        {
            base.Draw();

            Console.ForegroundColor = Colour;
            Console.SetCursorPosition(Left, Top);
            Console.Write(Char);


        }



    }
}
