using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTOs;
using FluentValidation;

namespace Application.Validators.Articulo
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
