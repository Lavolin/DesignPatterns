using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern.Shapes
{
    class Rectangle : CompositeElement
    {
        public Rectangle(int size, char @char) : base(size, @char)
        {
        }

        public override void Draw()
        {
            base.Draw();
            for (int row = 0; row < Size; row++)
            {
                for (int col = 0; col < Size * 2; col++)
                {
                    if (col == 0 || col == Size * 2 - 1 || row == 0 || row == Size - 1)
                    {
                        Console.ForegroundColor = Colour;
                        Console.SetCursorPosition(Left + row, Top + col);
                        Console.Write(Char);

                    }
                }
            }
        }

       
       
    }
}
