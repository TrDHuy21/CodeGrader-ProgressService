using Domain.ValueEntities;

namespace Domain.Entities
{
    public class Submission : IEntityId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public string ProgrammingLanguage { get; set; }
        public int Point { get; set; }
        public DateTime SubmissionAt { get; set; }
        public EvaluationCriteria EvaluationCriteria { get; set; }
    }
}
