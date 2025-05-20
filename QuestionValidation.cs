using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuizApp.Core.Validation {
  public class QuestionValidation : ValidationAttribute {
    public int Minimum { get; set; }
    public int Maximum { get; set; }
    public int MinimumOptions { get; set; }

    public QuestionValidation() {
      this.Minimum = 5;
      this.Maximum = 20;
      this.MinimumOptions = 4;
    }

    protected override ValidationResult IsValid(object value, ValidationContext context) {
      var questions = value as ICollection<Question>;
      if (questions == null || questions.Count == 0)
        return new ValidationResult($"A quiz should have at least {Minimum} questions");

      if (questions.Count < Minimum || questions.Count > Maximum)
        return new ValidationResult($"A quiz should have between {Minimum} and {Maximum} questions");

      foreach (var question in questions) {
        if (question.Options == null || question.Options.Count != MinimumOptions)
          return new ValidationResult($"Each question should have {MinimumOptions} valid options");
      }

      return ValidationResult.Success;
    }
  }
}