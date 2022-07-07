using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class PlusCommand : Command
    {
        public PlusCommand(double amount, string expression) : base(amount, expression)
        {

        }
        public override void Execute(double amount)
        {
            Amount += amount;
            Expression += " + " + amount;
        }

        public override bool IsValid(string sign)
        {
            return sign == "+";
        }

        //public override void UnExecute()
        //{
        //    Result -= Amount;
        //}
    }
}
