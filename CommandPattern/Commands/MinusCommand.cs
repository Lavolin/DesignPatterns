using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class MinusCommand : Command
    {
        public MinusCommand(double amount, string expression) : base(amount, expression)
        {

        }
        public override void Execute(double amount)
        {
            Amount -= amount;
            Expression += " - " + amount;
        }

        public override bool IsValid(string sign)
        {
            return sign == "-";
        }
    }
}
