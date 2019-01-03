using System;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Core.Base;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class AtualizarEventoCommand : Command
    {
        public AtualizarEventoCommand(Guid id, string nome, string descricaoCurta, string descricaoLonga, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa)
        {
            this.Id = id;
            this.Nome = nome;
            this.DescricaoCurta = descricaoCurta;
            this.DescricaoLonga = descricaoLonga;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Gratuito = gratuito;
            this.Valor = valor;
            this.Online = online;
            this.NomeEmpresa = nomeEmpresa;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
    }
}