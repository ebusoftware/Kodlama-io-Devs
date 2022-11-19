using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage
{
    public class UpdateLanguageCommandValidator : AbstractValidator<UpdateProgrammingLanguageCommand>
    {
        public UpdateLanguageCommandValidator()
        {
            RuleFor(u => u.Name).NotEmpty();
        }
    }
}
