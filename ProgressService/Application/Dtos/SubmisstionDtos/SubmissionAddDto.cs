using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos.SubmisstionDtos
{
    public class SubmissionAddDto
    {
        public int ProblemId { get; set; }
        public string Language { get; set; }
        public int Point { get; set; }
        public DateTime SubmisstionAt { get; set; }
        public EvaluaCriteriaDto EvaluaCriteria { get; set; }
    }
}
