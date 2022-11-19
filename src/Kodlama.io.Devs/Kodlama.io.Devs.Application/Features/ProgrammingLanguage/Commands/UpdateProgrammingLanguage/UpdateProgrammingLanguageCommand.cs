using AutoMapper;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Dtos.ProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Rules;
using Kodlama.io.Devs.Application.Services.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommand:IRequest<UpdatedProgrammingLanguageDto>
    {
        public int Id{ get; set; }
        public string Name { get; set; }

        public class UpdateProgrammingLanguageCommandHandler : IRequestHandler<UpdateProgrammingLanguageCommand, UpdatedProgrammingLanguageDto>
        {
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _businessRules;

            public UpdateProgrammingLanguageCommandHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules businessRules)
            {
                _programmingLanguageRepository = programmingLanguageRepository;
                _mapper = mapper;
                _businessRules = businessRules;

            }

            public async Task<UpdatedProgrammingLanguageDto> Handle(UpdateProgrammingLanguageCommand request, CancellationToken cancellationToken)
            {
                Domain.Entities.ProgrammingLanguage mappedLanguage = _mapper.Map<Domain.Entities.ProgrammingLanguage>(request);
                Domain.Entities.ProgrammingLanguage updatedLanguage = await _programmingLanguageRepository.UpdateAsync(mappedLanguage);
                UpdatedProgrammingLanguageDto updatedLanguageDto = _mapper.Map<UpdatedProgrammingLanguageDto>(updatedLanguage);

                return updatedLanguageDto;

            }
        }
    }
}
