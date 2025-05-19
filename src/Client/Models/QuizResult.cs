namespace QuizApp.Models
{
  public class QuizResult
  {
    public required int CategoryId
    {
      get; set;
    }
    public required string QuizTitle
    {
      get; set;
    }
    public required float Percentage
    {
      get; set;
    }
    public required int TotalQuestions
    {
      get; set;
    }
    public required int CorrectAnswers
    {
      get; set;
    }
    public required int IncorrectAnswers
    {
      get; set;
    }
  }
}
