using System;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Core.Base;
using Eventos.IO.Domain.Core.Interface;
using Eventos.IO.Domain.Core.Interfaces;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Events;
using Eventos.IO.Domain.Eventos.Interfaces;

namespace Eventos.IO.Domain.Eventos.Handlers
{
    public class EventoCommandHandler : BaseCommandHandler,
        IHandler<RegistrarEventoCommand>,
        IHandler<AtualizarEventoCommand>,
        IHandler<ExcluirEventoCommand>
    {
        #region Construtor / Propriedades

        private readonly IEventoRepository _eventoRepository;

        public EventoCommandHandler(IEventoRepository eventoRepository, IUnitOfWork unitOfWork, IBus bus, IDomainNotificationHandler<DomainNotification> notification)
            :base(unitOfWork, bus, notification)
        {
            this._eventoRepository = eventoRepository;
        }

        #endregion 

        public void Handle(RegistrarEventoCommand message)
        {
            var evento = new Evento(
                message.Nome,
                null,
                null,
                message.DataInicio,
                message.DataFim,
                message.Gratuito,
                message.Valor,
                message.Online,
                message.NomeEmpresa
            );

            if(!evento.EhValido()){
                NotificarValidacoesErro(evento.ObterErrosValidacao());
            }

            // TODO
            // Organizador pode registrar evento ?
             
            _eventoRepository.Add(evento);

            if(Commit().Success)
            {
                Console.WriteLine("Evento registrado com sucesso");
                _bus.RaiseEvent(new EventoRegistradoEvent(evento.Id, evento.Nome, evento.DataInicio, evento.DataFim, evento.Gratuito, evento.Valor, evento.Online, evento.NomeEmpresa));
            }
        }

        public void Handle(AtualizarEventoCommand message)
        {
            throw new System.NotImplementedException();
        }

        public void Handle(ExcluirEventoCommand message)
        {
            throw new System.NotImplementedException();
        }
    }
}