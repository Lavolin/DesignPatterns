using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    abstract class CompositeElement
    {
        protected List<CompositeElement> children;

        public CompositeElement(int size, char @char)
        {
            this.children = new List<CompositeElement>();
            Size = size;
            Char = @char;
            Colour = ConsoleColor.White;
        }

        public int Top { get; set; }
        public int Left { get; set; }
        public int Size { get; set; }
        public Char Char { get; set; }
        public ConsoleColor Colour { get; set; }

        public void AddChild(CompositeElement element)
        {
            children.Add (element);
        }

        public void RemoveChild(CompositeElement element)
        {
            children.Remove(element);
        }

        

        public virtual void Draw()
        {
            foreach (var child in children)
            {
                child.Draw();
            }
        }
        public virtual void Move(int top, int left)
        {
            foreach (var child in children)
            {
                child.Move(top, left);
            }
            Top += top;
            Left += left;

        }
        public virtual void Color(ConsoleColor color)
        {
            foreach (var child in children)
            {
                child.Color(color);
            }
            Colour = color;
        }
        public virtual void Resize(int times)
        {
            foreach (var child in children)
            {
                child.Resize(times);
            }
        }
    }
}


