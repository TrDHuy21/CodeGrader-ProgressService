using Application.Dtos.Resquest;
using Application.ExternalServices.Interface;
using Application.Services.Interface;
using Common.ResultPattern;
using Domain.Entities;
using Infrastructure.UnitOfWorks;

namespace Application.Services.Implementation
{
    public class UserProgressService : IUserProgressService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProblemExternalService _problemExternalService;


        public UserProgressService(IUnitOfWork unitOfWork, IProblemExternalService problemExternalService)
        {
            _unitOfWork = unitOfWork;
            _problemExternalService = problemExternalService;
        }

        public async Task<Result<GradedResult>> AddUserProgressAsync(GradedResult gradedResult)
        {
            // Lấy UserProgress hiện tại
            var userProgressResult = await _unitOfWork.UserProgress.GetById(gradedResult.UserId);
            UserProgress userProgressEntity = userProgressResult.Data;

            // Lấy thông tin bài từ service
            var problemResult = await _problemExternalService.GetProblemById(gradedResult.ProblemId);
            if (problemResult.Data == null)
                return Result<GradedResult>.Failure("Problem not found");

            int level = problemResult.Data.Level; // Level bài hiện tại

            // Nếu UserProgress chưa có → tạo mới
            if (!userProgressResult.IsSuccess || userProgressEntity == null)
            {
                userProgressEntity = new UserProgress
                {
                    Id = gradedResult.UserId,
                    TotalSubmission = 1,
                    EasySolved = 0,
                    MediumSolved = 0,
                    HardSolved = 0,
                    Rank = 0
                };
            }
            else
            {
                userProgressEntity.TotalSubmission++;
            }

            // Cập nhật số bài và Rank theo point bài vừa submit
            switch (level)
            {
                case 1:
                    userProgressEntity.EasySolved++;
                    userProgressEntity.Rank += gradedResult.Point * 1;
                    break;
                case 2:
                    userProgressEntity.MediumSolved++;
                    userProgressEntity.Rank += gradedResult.Point * 2;
                    break;
                case 3:
                    userProgressEntity.HardSolved++;
                    userProgressEntity.Rank += gradedResult.Point * 3;
                    break;
            }

            // Lưu UserProgress
            try
            {
                if (!userProgressResult.IsSuccess || userProgressEntity == null)
                    await _unitOfWork.UserProgress.AddAsync(userProgressEntity);
                else
                     _unitOfWork.UserProgress.UpdateAsync(userProgressEntity);

                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception)
            {
                return Result<GradedResult>.Failure("Add user progress failed");
            }

            return Result<GradedResult>.Success("Add user progress successfully", null);
        }



        public async Task<Result<UserProgress>> GetUserProgress(int userId)
            {
            var result = await _unitOfWork.UserProgress.GetById(userId);
            if(!result.IsSuccess)
            {
                return Result<UserProgress>.Failure("User id not found");
            }
            return Result<UserProgress>.Success(result.Data);
        }

        public async Task<Result<List<UserProgress>>> GetUserProgress()
        {
            var result = await _unitOfWork.UserProgress.GetAllAsync();
            return Result<List<UserProgress>>.Success(result.Data);
        }
    }
}
