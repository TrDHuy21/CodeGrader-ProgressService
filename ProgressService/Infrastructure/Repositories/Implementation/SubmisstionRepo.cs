using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Contexts;
using Infrastructure.Repositories.Interface;

namespace Infrastructure.Repositories.Implementation
{
    public class SubmisstionRepo : GenericRepo<Submission>, ISubmissionRepo
    {

        protected readonly ProgressContext _progressContext;

        public SubmisstionRepo(ProgressContext context) : base(context)
        {
            _progressContext = context;
        }
    }
}
