using AppLogic.DTOs;
using FluentValidation;

namespace AppLogic.Validators.Articulo
{
    public class CrearArticuloDtoValidator : AbstractValidator<CrearArticuloDTO>
    {
        public CrearArticuloDtoValidator()
        {
            RuleFor(x => x.Referencia)
                .NotEmpty().WithMessage("Referencia obligatoria")
                .MaximumLength(20);

            RuleFor(x => x.Descripcíon)
                .MaximumLength(100);
        }
    }
}
