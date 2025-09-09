using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.ProblemStatsDtos;
using Application.Dtos.Resquest;
using Application.Services.Interface;
using Common.ResultPattern;

namespace Application.Services.Implementation
{
    public class ProblemStatsService : IProblemStatsService
    {
        public async  Task<Result<List<ProblemStatsIndexDto>>> GetAllProblemStatsAync()
        {
            return Result<List<ProblemStatsIndexDto>>.Failure("Not implement");
        }

        public async Task<Result<ProblemStatsIndexDto>> GetProblemStatsByIdAync(int problemId)
        {
            return Result<ProblemStatsIndexDto>.Failure("Not implement");
        }

        public async Task<Result> AddProblemStatAsync(GradedResult gradedResult)
        {
            return Result.Failure("Not implement");
        }

    
    }
}
