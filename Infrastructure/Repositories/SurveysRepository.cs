using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class SurveysRepository : GenericRepository<Survey>, ISurveysRepository
    {

        protected readonly SurveyDbContext _context;
        public SurveysRepository(SurveyDbContext context) : base(context)
        {
            _context = context;
        }
    }
}