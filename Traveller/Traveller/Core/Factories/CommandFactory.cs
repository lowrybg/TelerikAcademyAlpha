﻿using Bytes2you.Validation;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;

namespace Traveller.Core.Factories
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IKernel kernel;

        public CommandFactory(IKernel kernel)
        {
            Guard.WhenArgument(kernel, "kernel").IsNull().Throw();
            this.kernel = kernel;
        }
        public ICommand CreateCommand(string commandName)
        {
            return this.kernel.Get<ICommand>(commandName);
        }
    }
}
