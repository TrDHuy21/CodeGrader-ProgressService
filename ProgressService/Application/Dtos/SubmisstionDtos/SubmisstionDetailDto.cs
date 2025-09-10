using Domain.ValueEntities;

namespace Application.Dtos.SubmisstionDtos
{
    public class SubmisstionDetailDto
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
