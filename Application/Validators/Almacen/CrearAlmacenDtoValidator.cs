using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLogic.DTOs;
using FluentValidation;

namespace Application.Validators.Almacen
{
    public class CrearAlmacenDtoValidator : AbstractValidator<CrearAlmacenDTO>
    {
        public CrearAlmacenDtoValidator()
        {
            RuleFor(x => x.Referencia)
            .NotEmpty().WithMessage("La referencia del almacén es obligatorio")
            .MaximumLength(20);

            RuleFor(x => x.IdDireccion)
                .GreaterThan(0).WithMessage("Debe proporcionar una dirección válida");
        }
    }
}
