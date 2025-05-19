namespace QuizApp.Models
{
  public class QuizSettings
  {
    public required bool Timer
    {
      get;
      set;
    }

    public int DurationSeconds
    {
      get; set;
    }

    public required bool OptionsFeedback
    {
      get; set;
    }

    public required bool Shuffle
    {
      get; set;
    }

    public required int NumberOfQuestions
    {
      get; set;
    }
    public required string QuizDifficulty
    {
      get; set;
    }
  }
}
