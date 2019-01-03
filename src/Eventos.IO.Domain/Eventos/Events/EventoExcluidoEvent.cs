using System;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoExcluidoEvent : Event
    {
        public EventoExcluidoEvent(Guid id)
        {
            this.Id = id;
            this.AggregateId = id;
        }

        public Guid Id { get; set; }
    }
}