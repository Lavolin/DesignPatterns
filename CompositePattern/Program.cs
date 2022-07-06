using CompositePattern.Shapes;
using System;
using System.Threading;

namespace CompositePattern
{
    class Program                   //2:06
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, '1');
            Rectangle rectangle2 = new Rectangle(2, '2');
            rectangle2.Left = 7;
            rectangle2.Top = 6;
            Rectangle rectangle3 = new Rectangle(3, '3');
            rectangle3.Left = 15;
            rectangle3.Top = 6;
            
            rectangle.AddChild(rectangle2);
            rectangle2.AddChild(rectangle3);

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
                rectangle.Draw();
                rectangle.Move(1, 2);
                Thread.Sleep(100);
            }
        }
    }
}
