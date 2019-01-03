using System;
using Eventos.IO.Domain.Core;

namespace Eventos.IO.Domain.Core.Base
{
    public  abstract class Command : Message
    {
        public Command()
        {
            TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp { get; private set; }
    }
}