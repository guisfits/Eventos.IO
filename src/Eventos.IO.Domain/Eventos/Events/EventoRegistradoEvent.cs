using System;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Eventos.Events
{
    public class EventoRegistradoEvent : Event
    {
        public EventoRegistradoEvent(Guid id, string nome, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa)
        {
            this.Id = id;
            this.Nome = nome;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Gratuito = gratuito;
            this.Valor = valor;
            this.Online = online;
            this.NomeEmpresa = nomeEmpresa;

            this.AggregateId = id;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
    }
}