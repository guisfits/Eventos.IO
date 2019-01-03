using System;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class AtualizarEventoCommand : BaseEventoCommand
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
    }
}