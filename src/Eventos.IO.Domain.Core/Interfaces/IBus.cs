using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Core.Interface
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;
        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}