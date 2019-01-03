using System;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class ExcluirEventoCommand : Command
    {
        public ExcluirEventoCommand(Guid id)
        {
            Id = id;
            AggregateId = id;
        }

        public Guid Id { get; private set; }
    }
}