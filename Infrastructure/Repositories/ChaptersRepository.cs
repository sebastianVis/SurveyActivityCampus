using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class ChaptersRepository : GenericRepository<Chapter>, IChaptersRepository
{
    protected readonly SurveyDbContext _context;
    public ChaptersRepository(SurveyDbContext context) : base(context)
    {
        _context = context;
    }
}
