using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CommandPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commandsReflection = Assembly.GetExecutingAssembly().GetTypes()
                .Where(x => typeof(Command).IsAssignableFrom(x) && x.Name != "Command").ToList();
            List<Command> commands = new List<Command>();

            foreach (var command in commandsReflection)
            {
                commands.Add((Command)Activator.CreateInstance(command, 0, ""));
            }

            Calculator calculator = new Calculator();
            while (true)
            {
                string sign = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());

                Command command = null;

                foreach (var item in commands)
                {
                    if (item.IsValid(sign))
                    {
                        command = Activator.CreateInstance(item.GetType()
                            , calculator.GetAmount(), calculator.GetExpression()) as Command;
                    }
                }
                
                if (sign == "u")
                {
                    calculator.UndoCommand();
                }

                if (command != null)
                {

                    calculator.ExecuteCommand(command, amount);
                }

                Console.Clear();
                Console.WriteLine($"{calculator.GetExpression()} = {calculator.GetAmount()}");
            }
        }
    }
}
