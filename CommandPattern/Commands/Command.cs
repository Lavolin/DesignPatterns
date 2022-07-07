using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    abstract class Command
    {
        protected Command(double amount, string expression)
        {
            Amount = amount;
            Expression = expression;
        }

        public double Amount  { get; set; }
        public string   Expression  { get; set; }

        public abstract void Execute(double amount);

        public abstract bool IsValid(string sign);
        
    }
}
