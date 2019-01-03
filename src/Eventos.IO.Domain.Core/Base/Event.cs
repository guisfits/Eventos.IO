using System;

namespace Eventos.IO.Domain.Core.Base
{
    public abstract class Event : Message
    {
        public Event()
        {
            this.TimeStamp = DateTime.Now;
        }
        
        public DateTime TimeStamp { get; set; }

    }
}