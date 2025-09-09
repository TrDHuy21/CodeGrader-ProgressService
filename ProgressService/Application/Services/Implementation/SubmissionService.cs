using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.SubmisstionDtos;
using Application.Services.Interface;
using Common.ResultPattern;

namespace Application.Services.Implementation
{
    public class SubmissionService : ISubmissionService
    {
        public Task<Result<SubmisstionDetailDto>> AddSubmission(SubmissionAddDto submissionAddDto)
        {
            throw new NotImplementedException();
        }

        public Task<Result<SubmisstionDetailDto>> GetSubmisstion(int submissionId)
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<SubmissionIndexDto>>> GetSubmisstionsByProblemId()
        {
            throw new NotImplementedException();
        }

        public Task<Result<List<SubmissionIndexDto>>> GetSubmisstionsByUserId()
        {
            throw new NotImplementedException();
        }
    }
}
