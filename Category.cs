using System;
using System.Collections.Generic;

namespace QuizApp.Core.Entities;

public class Category : BaseEntity {

  public required string Name { get; set; }

  public required string Description { get; set; }

  public string? ImageUrl { get; set; }

  public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

}
