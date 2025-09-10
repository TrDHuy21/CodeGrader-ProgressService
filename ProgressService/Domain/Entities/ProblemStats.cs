namespace Domain.Entities
{
    public class ProblemStats : IEntityId
    {
        public int Id { get; set; }
        public int TotalSubmission { get; set; }
        public int AvgPoint { get; set; }
    }
}
