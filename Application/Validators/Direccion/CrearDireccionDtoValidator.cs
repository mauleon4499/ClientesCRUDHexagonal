using AppLogic.DTOs;
using FluentValidation;

namespace AppLogic.Validators.Direccion
{
    public class CrearDireccionDtoValidator : AbstractValidator<CrearDireccionDTO>
    {
        public CrearDireccionDtoValidator()
        {
            RuleFor(x => x.Calle)
                .NotEmpty().WithMessage("La calle es obligatoria.")
                .Length(1, 100).WithMessage("La calle debe tener entre 1 y 100 caracteres.");
            RuleFor(x => x.Numero)
                .NotEmpty().WithMessage("El número es obligatorio.")
                .Length(1, 10).WithMessage("El número debe tener entre 1 y 10 caracteres.");
            RuleFor(x => x.CP)
                .NotEmpty().WithMessage("El código postal es obligatorio.")
                .Length(5).WithMessage("El código postal debe tener exactamente 5 caracteres.");
            RuleFor(x => x.Ciudad)
                .NotEmpty().WithMessage("La ciudad es obligatoria.")
                .Length(1, 50).WithMessage("La ciudad debe tener entre 1 y 50 caracteres.");
            RuleFor(x => x.Provincia)
                .NotEmpty().WithMessage("La provincia es obligatoria.")
                .Length(1, 50).WithMessage("La provincia debe tener entre 1 y 50 caracteres.");
        }
    }
}
