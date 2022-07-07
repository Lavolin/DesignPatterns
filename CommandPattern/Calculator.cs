using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    class Calculator
    {
        private List<Command> commands = new List<Command>();
        private int index = -1;

        public void ExecuteCommand(Command command, double amount)
        {
            commands.Add(command);
            command.Execute(amount);
            index++;
        }

        public void UndoCommand()
        {
            if (index >= 0)
            {
                commands.RemoveAt(index);
                index--;
            }
        }

        public double GetAmount()
        {
            if (index >= 0)
            {
               return commands[index].Amount;
            }

            return 0;
        }

        public string GetExpression()
        {
            if (index >= 0)
            {
                return $"{commands[index].Expression}";
            }

            return "0";
        }
    }
}
