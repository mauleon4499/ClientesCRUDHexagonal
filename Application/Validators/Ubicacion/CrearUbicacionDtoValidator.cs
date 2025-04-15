using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators.Ubicacion
{
    public class CrearUbicacionDtoValidator : AbstractValidator<CrearUbicacionDTO>
    {
        public CrearUbicacionDtoValidator()
        {
            RuleFor(x => x.Referencia)
            .NotEmpty().WithMessage("La referencia es obligatorio")
            .MaximumLength(50);

            RuleFor(x => x.IdAlmacen)
                .GreaterThan(0).WithMessage("Debe asociar un almacén");
        }
    }
}
