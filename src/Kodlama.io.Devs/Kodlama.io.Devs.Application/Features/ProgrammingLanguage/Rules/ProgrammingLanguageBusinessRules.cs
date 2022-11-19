using Core.CrossCuttingConcerns.Exceptions;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Application.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Rules
{
    public class ProgrammingLanguageBusinessRules
    {
        private readonly IProgrammingLanguageRepository _programmingLanguageRepository;

        public ProgrammingLanguageBusinessRules(IProgrammingLanguageRepository programmingLanguageRepository)
        {
            _programmingLanguageRepository = programmingLanguageRepository;
        }
        public async Task ProgrammingLanguageNameCanNotBeDuplicatedWhenInserted(string name)
        {
            IPaginate<Domain.Entities.ProgrammingLanguage> result = await _programmingLanguageRepository.GetListAsync(b => b.Name == name);
            if (result.Items.Any()) throw new BusinessException("Programming language name exists.");
        }
        public async Task ProgrammingLanguageShouldExistWhenRequested(Domain.Entities.ProgrammingLanguage programmingLanguage)
        {
            if (programmingLanguage == null) throw new BusinessException("Request Programming Language does not exists.");
        }
        public async Task LanguageNameMustBeExistedWhenDeleted(int id)
        {
            IPaginate<Domain.Entities.ProgrammingLanguage> result = await _programmingLanguageRepository.GetListAsync(l => l.Id == id);
            if (!result.Items.Any()) throw new BusinessException("Programming language should be existed");
        }
    }
}
