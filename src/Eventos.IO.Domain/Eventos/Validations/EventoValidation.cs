using FluentValidation;

namespace Eventos.IO.Domain.Eventos.Validations
{
    public class EventoValidation : AbstractValidator<Evento>
    {
        public void ValidarNome(){
            RuleFor(x => x.Nome)
                .NotNull()
                .NotEmpty()
                .WithMessage("Nome não deve estar vazio");
        }

        public void ValidarValor(){
            RuleFor(x => x.Valor)
                .NotNull()
                .When(x => x.Gratuito == false)
                .WithMessage("Valor inválido");
        }
    }
}