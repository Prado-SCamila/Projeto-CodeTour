using CodeTur.Comum.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTur.Comum.Handlers.Contracts
{
    // <T> --> Tipo de objeto generico 
    // where --> Garante que este objeto generico estaja herdando da interface ICommand
    public interface IHandler<T> where T : ICommand
    {
        ICommandResult Handler(T command);
    }
}
