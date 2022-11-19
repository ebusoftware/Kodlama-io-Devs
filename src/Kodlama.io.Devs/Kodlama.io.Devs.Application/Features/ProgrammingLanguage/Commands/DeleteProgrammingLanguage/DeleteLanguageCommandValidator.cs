using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.DeleteProgrammingLanguage
{
    public class DeleteLanguageCommandValidator : AbstractValidator<DeleteProgrammingLanguageCommand>
    {
        public DeleteLanguageCommandValidator()
        {
            RuleFor(d => d.Id).NotEmpty();
        }
    }
}
