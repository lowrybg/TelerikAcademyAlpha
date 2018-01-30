using Bytes2you.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;
using Traveller.Core.Contracts;

namespace Traveller.Commands.Decorators
{
    class LoggingCommandDecorator : ICommand
    {
        private readonly ICommand command;
        private readonly IWriter writer;

        public LoggingCommandDecorator(ICommand command, IWriter writer)
        {
            Guard.WhenArgument(command, "command").IsNull().Throw();
            Guard.WhenArgument(writer, "writer").IsNull().Throw();
            this.command = command;
            this.writer = writer;
        }


        public string Execute(IList<string> parameters)
        {

            this.writer.Write($"The Engine is starting {DateTime.Now}!");
            this.writer.Write(Environment.NewLine);
            return this.command.Execute(parameters);
        }
    }
}
