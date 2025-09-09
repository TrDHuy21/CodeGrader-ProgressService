using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.SubmisstionDtos;
using Common.ResultPattern;

namespace Application.Services.Interface
{
    public interface ISubmisstionService
    {
        public Task<Result<SubmisstionDetailDto>> GetSubmisstion(int submissionId);
        public Task<Result<List<SubmissionIndexDto>>> GetSubmisstionsByUserId();
        public Task<Result<List<SubmisstionDetailDto>>> GetAllSubmission();
        public Task<Result<List<SubmissionIndexDto>>> GetSubmisstionsByProblemId(int problemId);
        public Task<Result<SubmisstionDetailDto>> AddSubmission(SubmissionAddDto submissionAddDto);
        public Task<Result<string>> DeleteSubmisstion(int submissionId);

    }
}
