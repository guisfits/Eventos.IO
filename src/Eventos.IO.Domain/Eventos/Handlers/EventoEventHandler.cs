using Eventos.IO.Domain.Core.Interface;
using Eventos.IO.Domain.Eventos.Events;

namespace Eventos.IO.Domain.Eventos.Handlers
{
    public class EventoEventHandler :
        IHandler<EventoRegistradoEvent>,
        IHandler<EventoAtualizadoEvent>,
        IHandler<EventoExcluidoEvent>
    {
        public void Handle(EventoRegistradoEvent message)
        {
            // Enviar e-mail
        }

        public void Handle(EventoAtualizadoEvent message)
        {
            // Salvar numa base NoSql de eventos
        }

        public void Handle(EventoExcluidoEvent message)
        {
            // Log
        }
    }
}