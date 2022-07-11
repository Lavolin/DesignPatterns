using CompositePattern.Shapes;
using System;
using System.Threading;

namespace CompositePattern
{
    class Program                   
    {
        static void Main(string[] args)
        {
            CompositeElement page = new CompositeElement(0, 'c');

            Rectangle rectangle = new Rectangle(7, '1');
            Rectangle rectangle2 = new Rectangle(2, '2');
            rectangle2.Left = 7;
            rectangle2.Top = 6;
            Rectangle rectangle3 = new Rectangle(3, '3');
            rectangle3.Left = 15;
            rectangle3.Top = 6;
            
            rectangle.AddChild(rectangle2);
            rectangle2.AddChild(rectangle3);

            Character A = new Character(0, 'A');
            A.Top = 2;
            A.Left = 4;

            rectangle.AddChild(A);

            page.AddChild(rectangle);

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Q)
                    {
                        rectangle.Color(ConsoleColor.Red);
                    }
                }
                Console.Clear();
                page.Draw();
                page.Move(1, 0);

                rectangle2.Draw();
                rectangle2.Move(0, 1);

                Thread.Sleep(500);
            }
        }
    }
}
