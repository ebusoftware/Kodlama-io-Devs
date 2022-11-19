using AutoMapper;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.CreateProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.DeleteProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Commands.UpdateProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Dtos;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Dtos.ProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Models.ProgrammingLanguageModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Domain.Entities.ProgrammingLanguage, CreatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<Domain.Entities.ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();

            CreateMap<Domain.Entities.ProgrammingLanguage, ProgrammingLanguageListDto>().ReverseMap();
            CreateMap<IPaginate<Domain.Entities.ProgrammingLanguage>, ProgrammingLanguageListModel>().ReverseMap();

            CreateMap<Domain.Entities.ProgrammingLanguage, ProgrammingLanguageGetByIdDto>().ReverseMap();


            CreateMap<Domain.Entities.ProgrammingLanguage, UpdatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<Domain.Entities.ProgrammingLanguage, UpdateProgrammingLanguageCommand>().ReverseMap();


            CreateMap<Domain.Entities.ProgrammingLanguage, DeletedProgrammingLanguageDto>().ReverseMap();
            CreateMap<Domain.Entities.ProgrammingLanguage, DeleteProgrammingLanguageCommand>().ReverseMap();





        }
    }
}
