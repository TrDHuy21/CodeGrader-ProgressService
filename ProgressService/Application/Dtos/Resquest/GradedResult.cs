using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.ValueEntities;

namespace Application.Dtos.Resquest
{
    public class GradedResult
    {
        public int UserId { get; set; }
        public int ProblemId { get; set; }
        public string Language { get; set; }
        public int Point{ get; set; }
        public EvaluationCriteria EvaluationCriteria { get; set; }
        public DateTime SubmissionAt { get; set; }
    }
}
