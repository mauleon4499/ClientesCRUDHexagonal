using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators.Inventario
{
    public class CrearInventarioDtoValidator : AbstractValidator<CrearInventarioDTO>
    {
        public CrearInventarioDtoValidator()
        {
            RuleFor(x => x.IdArticulo)
            .GreaterThan(0).WithMessage("Debe seleccionar un artículo");

            RuleFor(x => x.IdUbicacion)
                .GreaterThan(0).WithMessage("Debe seleccionar una ubicación");

            RuleFor(x => x.Cantidad)
                .GreaterThanOrEqualTo(0).WithMessage("La cantidad no puede ser negativa");
        }
    }
}
