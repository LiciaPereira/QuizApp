using System;
using System.Collections.Generic;

namespace QuizApp.Core.Entities;

public enum Difficulty { Easy, Medium, Hard }

public class Question : BaseEntity {

  public required Quiz Quiz { get; set; }

  public required int QuizId { get; set; }

  public required string QuestionText { get; set; }

  public required ICollection<Option> Options { get; set; } = new List<Option>();

  public required int CorrectAnswerId { get; set; }

  public required Difficulty Difficulty { get; set; }

}
