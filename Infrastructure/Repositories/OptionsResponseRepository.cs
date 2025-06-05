using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Entities;
using Infrastructure.Data;

namespace Infrastructure.Repositories;

public class OptionsResponseRepository : GenericRepository<OptionsResponse>, IOptionsReponseRepository
{
    private readonly SurveyDbContext _context;

    public OptionsResponseRepository(SurveyDbContext context) : base(context)
    {
        _context = context;
    }
}
