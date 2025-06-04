using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options)
        {

        }

        public DbSet<CategoriesCatalog> CategoriesCatalogs { get; set; }
        public DbSet<CategoryOptions> CategoryOptions { get; set; }
        public DbSet<Chapters> Chapters { get; set; }
        public DbSet<OptionsResponse> OptionsResponses { get; set; }
        public DbSet<Surveys> Surveys { get; set; }
        public DbSet<OptionQuestions> OptionQuestions { get; set; }
        public DbSet<SubQuestions> SubQuestions { get; set; }
        public DbSet<Questions> Questions { get; set; }
        public DbSet<SumaryOptions> SumaryOptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}