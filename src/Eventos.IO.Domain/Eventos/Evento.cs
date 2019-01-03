using System;
using System.Collections.Generic;
using Eventos.IO.Domain.Core;
using Eventos.IO.Domain.Eventos.Validations;
using Eventos.IO.Domain.Organizadores;
using FluentValidation.Results;

namespace Eventos.IO.Domain.Eventos 
{
    public class Evento : Entity 
    {
        public Evento (string nome, string descricaoCurta, string descricaoLonga, DateTime dataInicio, DateTime dataFim, bool gratuito, decimal valor, bool online, string nomeEmpresa) 
        {
            this.Id = Guid.NewGuid ();
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

        public string Nome { get; private set; }
        public string DescricaoCurta { get; private set; }
        public string DescricaoLonga { get; private set; }
        public DateTime DataInicio { get; private set; }
        public DateTime DataFim { get; private set; }
        public bool Gratuito { get; private set; }
        public decimal Valor { get; private set; }
        public bool Online { get; private set; }
        public string NomeEmpresa { get; private set; }
        public Categoria Categoria { get; private set; }
        public ICollection<Tag> Tags { get; private set; }
        public Endereco Endereco { get; private set; }
        public Organizador Organizador { get; private set; }

        public bool EhValido() 
        {
            Validar ();
            return _validationResult.IsValid;
        }

        public IList<ValidationFailure> ObterErrosValidacao() 
        {
            return _validationResult.Errors;
        }

        #region Privates

        private ValidationResult _validationResult;
        private void Validar () 
        {
            var eventoValidation = new EventoValidation ();
            eventoValidation.ValidarNome ();
            eventoValidation.ValidarValor ();

            _validationResult = eventoValidation.Validate (this);
        }

        #endregion
    }
}