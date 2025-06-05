using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUnitOfWork
    {
        ICategoriesCatalogRepository CategoriesCatalogs { get; }
        ICategoryOptionsRepository CategoryOptions { get; }
        IChaptersRepository Chapters { get; }
        IOptionQuestionsRepository OptionQuestions { get; }
        IOptionsReponseRepository OptionsResponses { get; }
        IQuestionsRepository Questions { get; }
        ISubQuestionsRepository SubQuestions { get; }
        ISumaryOptionsRepository SumaryOptions { get; }
        ISurveysRepository Surveys { get; }
        Task<int> SaveAsync();
    }
}