﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traveller.Commands.Contracts;

namespace Traveller.Core.Providers
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            
            Console.Write(message);
        }
    }
}
