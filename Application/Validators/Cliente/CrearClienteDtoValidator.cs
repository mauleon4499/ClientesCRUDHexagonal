using Application.DTOs;
using FluentValidation;

namespace Application.Validators.Cliente
{
    public class CrearClienteDtoValidator : AbstractValidator<CrearClienteDTO>
    {
        public CrearClienteDtoValidator()
        {
            RuleFor(x => x.Nombre)
            .NotEmpty().WithMessage("El nombre es obligatorio")
            .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres")
            .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres");

            RuleFor(x => x.Email)
            .NotEmpty().WithMessage("El Email es obligatorio")
            .EmailAddress().WithMessage("El formato del Email es incorrecto")
            .MaximumLength(50).WithMessage("El nombre no puede tener más de 50 caracteres")
            .MinimumLength(3).WithMessage("El nombre debe tener al menos 3 caracteres");

            RuleFor(x => x.IdDireccion).GreaterThan(0).WithMessage("Debe seleccionar una dirección válida");
        }
    }
}
