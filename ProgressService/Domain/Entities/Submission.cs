using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueEntities;

namespace Domain.Entities
{
    public class Submission : IEntityId
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public string Language { get; set; }
        public int Point { get; set; }
        public DateTime SubmisstionAt { get; set; }
        public EvaluationCriteria EvaluationCriteria { get; set; }
    }
}
