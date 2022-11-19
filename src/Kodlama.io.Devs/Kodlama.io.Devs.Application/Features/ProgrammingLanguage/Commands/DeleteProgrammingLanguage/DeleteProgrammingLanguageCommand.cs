using AutoMapper;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Dtos.ProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Rules;
using Kodlama.io.Devs.Application.Services.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.DeleteProgrammingLanguage
{
    public class DeleteProgrammingLanguageCommand:IRequest<DeletedProgrammingLanguageDto>
    {
        public int Id { get; set; }
        public class DeleteProgrammingLanguageCommandHandler : IRequestHandler<DeleteProgrammingLanguageCommand, DeletedProgrammingLanguageDto>
        {
            private readonly IMapper _mapper;
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly ProgrammingLanguageBusinessRules _programmingLanguageBusiness;

            public DeleteProgrammingLanguageCommandHandler(IMapper mapper, IProgrammingLanguageRepository programmingLanguageRepository, ProgrammingLanguageBusinessRules programmingLanguageBusiness)
            {
                _mapper = mapper;
                _programmingLanguageRepository = programmingLanguageRepository;
                _programmingLanguageBusiness = programmingLanguageBusiness;
            }

            public async Task<DeletedProgrammingLanguageDto> Handle(DeleteProgrammingLanguageCommand request, CancellationToken cancellationToken)
            {
                await _programmingLanguageBusiness.LanguageNameMustBeExistedWhenDeleted(request.Id);

                Domain.Entities.ProgrammingLanguage mappedLanguage = _mapper.Map<Domain.Entities.ProgrammingLanguage>(request);
                Domain.Entities.ProgrammingLanguage deletedLanguage = await _programmingLanguageRepository.DeleteAsync(mappedLanguage);
                DeletedProgrammingLanguageDto deletedLanguageDto = _mapper.Map<DeletedProgrammingLanguageDto>(deletedLanguage);
                return deletedLanguageDto;


            }
        }
    }
}
