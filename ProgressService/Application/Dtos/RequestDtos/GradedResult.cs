using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.SubmisstionDtos;

namespace Application.Dtos.RequestDtos
{
    public class GradedResult
    {
        public int ProblemId { get; set; }
        public string Language { get; set; }
        public int Point { get; set; }
        public int SubmissionAt { get; set; }
        public EvaluationCriteria EvaluationCriteria {get; set;}

    }

    public class EvaluationCriteria
    {
        public string Algorithm { get; set; }
        public string CleanCode { get; set; }
    }
}
