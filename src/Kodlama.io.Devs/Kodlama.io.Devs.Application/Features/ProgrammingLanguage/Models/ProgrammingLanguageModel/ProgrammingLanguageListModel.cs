using Core.Persistence.Paging;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Dtos.ProgrammingLanguage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguage.Models.ProgrammingLanguageModel
{
    public class ProgrammingLanguageListModel: BasePageableModel
    {
        public List<ProgrammingLanguageListDto> Items { get; set; }
    }
}
