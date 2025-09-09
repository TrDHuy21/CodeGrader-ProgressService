using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Dtos.Resquest;
using Common.ResultPattern;

namespace Application.Services.Interface
{
    public interface IUserProgressService
    {
        Task<Result> GetUserProgress(int userId);

        Task<Result> GetUserProgress();

        Task<Result> AddUserProgressAsync(GradedResult gradedResult);

       
    }
}
