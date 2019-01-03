using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Interfaces;

namespace Eventos.IO.Domain.Eventos.CommandHandlers
{
    public class EventoCommandHandler : BaseCommandHandler,
        IHandler<RegistrarEventoCommand>,
        IHandler<AtualizarEventoCommand>,
        IHandler<ExcluirEventoCommand>
    {
        #region Construtor / Propriedades

        private readonly IEventoRepository _eventoRepository;

        public EventoCommandHandler(IEventoRepository eventoRepository, IUnitOfWork unitOfWork)
            :base(unitOfWork)
        {
            this._eventoRepository = eventoRepository;
        }

        #endregion 

        public void Handle(RegistrarEventoCommand message)
        {
            var evento = new Evento(
                message.Nome,
                message.DescricaoCurta,
                message.DescricaoLonga,
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
                // Notificar processo concluido!
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