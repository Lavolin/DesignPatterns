using System;
using System.Collections.Generic;
using System.Text;

namespace ShallowDeepCopy
{
    public class Sandwich : IPrototype<Sandwich>
    {
        private string bread;
        private string meat;
        private string cheese;
        private string veggies;
        
        public Sandwich(string bread, string meat, string cheese, string veggies, Test test)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
            this.Test = test;
        }

        public Test Test { get; set; }

        public Sandwich ShallowCopy()
            => this.MemberwiseClone() as Sandwich;

        public Sandwich DeepCopy()
        {
            Sandwich copy = this.MemberwiseClone() as Sandwich;

            copy.bread = new string(bread);
            copy.meat = new string(meat);
            copy.cheese = new string(cheese);
            copy.veggies = new string(veggies);
            copy.Test = new Test(copy.Test.Integer);

            return copy;
        }
    }

    public class Test
    {
        public Test(int integer)
        {
            Integer = integer;
        }

        public int Integer { get; set; }
    }
}
