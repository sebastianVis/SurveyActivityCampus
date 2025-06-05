using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class QuestionsRepository : GenericRepository<Question>, IQuestionsRepository
    {
        protected readonly SurveyDbContext _context;
        public QuestionsRepository(SurveyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}