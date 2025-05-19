using System;
using System.Collections.Generic;

namespace QuizApp.Core.Entities;

public class Quiz: BaseEntity {

  public required Category Category { get; set; }

  public required string Name { get; set; }

  public ICollection<Question> Questions { get; set; } = new List<Question>();

  public required int QuestionsAmount { get; set; }

  public bool Timer { get; set; }
	
	public TimeSpan? TimerDuration { get; set; }

  public bool Feedback { get; set; }

}
