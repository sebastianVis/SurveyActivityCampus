using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly SurveyDbContext? _context;
        private ICategoriesCatalogRepository? _categoriesCatalog;
        private ICategoryOptionsRepository? _categoryOption;
        private IChaptersRepository? _chapters;
        private IOptionQuestionsRepository? _optionQuestion;
        private IOptionsReponseRepository? _optionsResponse;
        private IQuestionsRepository? _question;
        private ISubQuestionsRepository? _subQuestion;
        private ISumaryOptionsRepository? _sumaryOption;
        private ISurveysRepository? _survey;
        public UnitOfWork(SurveyDbContext context)
        {
            _context = context;
        }

        public ICategoriesCatalogRepository CategoriesCatalogs
        {
            get
            {
                if (_categoriesCatalog == null)
                {
                    _categoriesCatalog = new CategoriesCatalogRepository(_context!);
                }
                return _categoriesCatalog;
            }
        }

        public ICategoryOptionsRepository CategoryOptions
        {
            get
            {
                if (_categoryOption == null)
                {
                    _categoryOption = new CategoryOptionsRepository(_context!);
                }
                return _categoryOption;
            }
        }
        public IChaptersRepository Chapters
        {
            get
            {
                if (_chapters == null)
                {
                    _chapters = new ChaptersRepository(_context!);
                }
                return _chapters;
            }
        }
        public IOptionQuestionsRepository OptionQuestions
        {
            get
            {
                if (_optionQuestion == null)
                {
                    _optionQuestion = new OptionQuestionsRepository(_context!);
                }
                return _optionQuestion;
            }
        }
        public IOptionsReponseRepository OptionsResponses
        {
            get
            {
                if (_optionsResponse == null)
                {
                    _optionsResponse = new OptionsResponseRepository(_context!);
                }
                return _optionsResponse;
            }
        }
        public IQuestionsRepository Questions
        {
            get
            {
                if (_question == null)
                {
                    _question = new QuestionsRepository(_context!);
                }
                return _question;
            }
        }
        public ISubQuestionsRepository SubQuestions
        {
            get
            {
                if (_subQuestion == null)
                {
                    _subQuestion = new SubQuestionsRepository(_context!);
                }
                return _subQuestion;
            }
        }
        public ISumaryOptionsRepository SumaryOptions
        {
            get
            {
                if (_sumaryOption == null)
                {
                    _sumaryOption = new SumaryOptionsRepository(_context!);
                }
                return _sumaryOption;
            }
        }
        public ISurveysRepository Surveys
        {
            get
            {
                if (_survey == null)
                {
                    _survey = new SurveysRepository(_context!);
                }
                return _survey;
            }
        }
        public async Task<int> SaveAsync()
        {
            return await _context!.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}