using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizApp.Core.Entities {
  public class Category : BaseEntity {

    [Required(ErrorMessage = "Category should have a name")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "Category should have a description")]
    public required string Description { get; set; }

    public string? ImageUrl { get; set; }

    public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();

  }
}