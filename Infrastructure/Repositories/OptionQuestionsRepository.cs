using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class OptionQuestionsRepository : GenericRepository<OptionQuestion>, IOptionQuestionsRepository
    {
        private readonly SurveyDbContext _context;
        public OptionQuestionsRepository(SurveyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}