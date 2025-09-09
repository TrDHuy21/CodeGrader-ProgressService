using Application.Dtos.Resquest;
using Application.Services.Interface;
using Common.ResultPattern;

namespace Application.Services.Implementation
{
    public class UserProgressService : IUserProgressService
    {
        public async Task<Result> AddUserProgressAsync(GradedResult gradedResult)
        {
            return Result.Failure("Not implement");
        }

        public async Task<Result> GetUserProgress()
        {
            return Result.Failure("Not implement");
        }

        public async Task<Result> GetUserProgress(int userId)
        {
            return Result.Failure("Not implement");
        }
    }
}
