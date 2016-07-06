﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoooooJu.Service.Bus.CommandHandlerFactory
{
    public interface ICommandHandlerFactory
    {
        CommandHandler.ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
