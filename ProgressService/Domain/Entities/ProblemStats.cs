using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ProblemStats : IEntityId
    {
        public int Id { get; set; }
        public int TotalSubmisstion { get; set; }
        public int AvgPoint { get; set; }
    }
}
