using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoooooJu.Service.Bus.Areas.Account.Commands;
using BoooooJu.Service.Bus.CommandHandler;

namespace BoooooJu.Service.Bus.Areas.Account.CommandHandlers
{
    public class RegisterAccountCommandHandler : ICommandHandler<RegisterAccountCommand>
    {

        public RegisterAccountCommandHandler()
        {

        }
        void ICommandHandler<RegisterAccountCommand>.Execute(RegisterAccountCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
