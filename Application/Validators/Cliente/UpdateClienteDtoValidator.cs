using AppLogic.DTOs;
using FluentValidation;

namespace AppLogic.Validators.Cliente
{
    public class UpdateClienteDtoValidator : AbstractValidator<UpdateClienteDTO>
    {
        public UpdateClienteDtoValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .WithMessage("El Nombre es requerido")
                .MaximumLength(50)
                .WithMessage("El Nombre no puede tener más de 50 caracteres");

            RuleFor(x => x.Email)
                .NotEmpty()
                .WithMessage("El Email es requerido")
                .EmailAddress()
                .WithMessage("El Email no es válido");

            RuleFor(x => x.IdDireccion)
                .NotEmpty()
                .WithMessage("La IdDireccion es requerida");
        }
    }
}
