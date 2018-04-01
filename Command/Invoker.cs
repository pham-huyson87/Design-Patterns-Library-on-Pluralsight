using System.Collections.Generic;

namespace Command
{
    public class Invoker
    {
        public Invoker()
        {
            List<ICommand> commandList = new List<ICommand>() {
                new CommandA(),
                new CommandB()
            };

            foreach (var command in commandList)
            {
                command.Execute();
            }
        }
    }
}
