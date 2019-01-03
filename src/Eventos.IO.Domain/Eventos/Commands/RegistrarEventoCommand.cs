using System;

namespace Eventos.IO.Domain.Eventos.Commands
{
    public class RegistrarEventoCommand : BaseEventoCommand
    {
        public RegistrarEventoCommand(string nome, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa)
        {
            this.Nome = nome;
            this.DataInicio = dataInicio;
            this.DataFim = dataFim;
            this.Gratuito = gratuito;
            this.Valor = valor;
            this.Online = online;
            this.NomeEmpresa = nomeEmpresa;
        }
    }
}