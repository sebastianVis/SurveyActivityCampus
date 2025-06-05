using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities;

public class Question
{
    public int Id { get; set; }
    public int ChapterId { get; set; }
    public Chapter? Chapter { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public string? QuestionNumber { get; set; }
    public string? ResponseType { get; set; }
    public string? CommentQuestion { get; set; }
    public string? QuestionText { get; set; }
    public ICollection<OptionQuestion>? OptionQuestions { get; set; }
    public ICollection<SubQuestion>? SubQuestions { get; set; }
}
