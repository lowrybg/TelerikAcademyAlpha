﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Commands.Contracts
{
    public interface IWriter
    {
        void Write(string message);
    }
}
