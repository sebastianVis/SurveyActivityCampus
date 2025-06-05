using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class OptionQuestion
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int OptionId { get; set; }
    public OptionsResponse? OptionsResponse { get; set; }
    public int OptionCatalogId { get; set; }
    public CategoriesCatalog? CategoriesCatalog { get; set; }
    public int OptionQuestionId { get; set; }
    public Question? Questions { get; set; }
    public int SubquestionId { get; set; }
    public SubQuestion? SubQuestions { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? CommentOptionRes { get; set; }
    public string? NumberOption { get; set; }
}