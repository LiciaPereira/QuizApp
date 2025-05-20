using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using QuizApp.Core.Validation;

public enum QuestionAmount { Five = 5, Ten = 10, Twenty = 20 }

namespace QuizApp.Core.Entities {
  public class Quiz : BaseEntity {

    public required Category Category { get; set; }

    public required int CategoryId { get; set; }

    [Required(ErrorMessage = "Quiz title is required")]
    [StringLength(100, MinimumLength = 5,
      ErrorMessage = "Title must be between {2} and {1} characters")]
    public required string Title { get; set; }

    [Required(ErrorMessage = "Quiz description is required")]
    [StringLength(500, ErrorMessage = "Description cannot exceed {1} characters")]
    public required string Description { get; set; }

    [Required(ErrorMessage = "The quiz should have questions")]
    [QuestionValidation(Minimum = 5, Maximum = 20, ErrorMessage = "There should be between {1} and {2} questions")]
    public ICollection<Question> Questions { get; set; } = new List<Question>();

    public bool CustomQuiz { get; set; }
  }
}