using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public enum Difficulty { Easy, Medium, Hard, Mix }
public enum QuestionAmount { Five = 5, Ten = 10, Twenty = 20 }

public class Settings : IValidatableObject {
  public bool Timer { get; set; }

  public TimeSpan? TimerDuration { get; set; }

  public bool Feedback { get; set; }

  public required int QuestionsAmount { get; set; }

  public required Difficulty Difficulty { get; set; }

  public IEnumerable<ValidationResult> Validate(ValidationContext validationContext) {
    if (Timer) {
      if (TimerDuration == null || TimerDuration.Value <= TimeSpan.Zero) {
        yield return new ValidationResult(
            "Timer duration must be set and greater than zero when the timer is enabled.",
            new[] { nameof(TimerDuration) }
        );
      }
    }
  }
}